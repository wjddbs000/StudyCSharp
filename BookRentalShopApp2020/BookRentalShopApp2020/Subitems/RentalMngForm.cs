using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp2020.Subitems
{
    public partial class RentalMngForm : MetroForm
    {
        #region 멤버변수 영역
        BaseMode myMode = BaseMode.NONE;
        readonly string strTblName = "memberTbl";
        #endregion
        #region 생성자 영역
        public RentalMngForm()
        {
            InitializeComponent();
        }
        #endregion
        #region 폼로드 영역
        private void MemberMngForm_Load(object sender, EventArgs e)
        {
            UpdateComboMember();
            UpdateComboBook();
            UpdateData();
            IninControls();
        }


        #endregion
        #region 커스텀 메서드 영역
        private void UpdateComboMember()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Idx,Names FROM membertbl ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", "");
                while (reader.Read())
                {
                    temps.Add(reader[1].ToString(), reader[0].ToString());
                }
                CboMember.DataSource = new BindingSource(temps, null);
                CboMember.DisplayMember = "key";
                CboMember.ValueMember = "Value";
            }
        }
        private void UpdateComboBook()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $" SELECT b.Idx, b.Names, " +
                                   "(SELECT Names FROM divtbl WHERE Division = b.Division) AS Division " +
                                   "   FROM bookstbl as b ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", "");
                while (reader.Read())
                {
                    temps.Add($"[{reader[2]}] {reader[1]}", $"{reader[0]}");
                }
                CboBook.DataSource = new BindingSource(temps, null);
                CboBook.DisplayMember = "key";
                CboBook.ValueMember = "Value";
            }

        }
        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"    SELECT r.idx AS '번호', " +
                                   "           m.Names AS '대여회원', " +
                                   "           b.Names AS '대여책제목', " +
                                   "           b.ISBN, " +
                                   "           r.rentalDate AS '대여일', " +
                                   "           r.returnDate AS '반납일', " +
                                   "           r.memberIdx, " +
                                   "           r.bookIdx " +
                                   "      FROM rentaltbl AS r " +
                                   "INNER JOIN membertbl AS m " +
                                   "        ON r.memberIdx = m.Idx " +
                                   "INNER JOIN bookstbl AS b " +
                                   "        ON r.bookIdx = b.Idx ";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strQuery;

                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                //adapter가 connand parameter DataReader 다 가능
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdRentalTbl.DataSource = ds;
                GrdRentalTbl.DataMember = strTblName;
            }
            SetColumHeaders();     //열 제목줄 수정!
        }

        private void SetColumHeaders()
        {
            DataGridViewColumn column;
            column = GrdRentalTbl.Columns[0];
            column.Width = 40;
            column.HeaderText = "번호";

            column = GrdRentalTbl.Columns[1];
            column.Width = 100;
            column.HeaderText = "회원";

            column = GrdRentalTbl.Columns[2];
            column.Width = 150;
            column.HeaderText = "책";

            column = GrdRentalTbl.Columns[3];
            column.Width = 110;
            column.HeaderText = "ISBN";

            column = GrdRentalTbl.Columns[4];
            column.Width = 110;

            column = GrdRentalTbl.Columns[5];
            column.Width = 110;

            column = GrdRentalTbl.Columns[6];
            column.Visible = false;
            column = GrdRentalTbl.Columns[7];
            column.Visible = false;


        }
        private void IninControls()
        {
            TxtIdx.Text = String.Empty;

            TxtIdx.Focus();
            TxtIdx.ReadOnly = true;

            CboMember.SelectedIndex = CboBook.SelectedIndex = 0;

            DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
            DtpRentalDate.Value = DateTime.Now;

            DtpReturnDate.CustomFormat = " ";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;

            myMode = BaseMode.NONE;
        }

        private void SaveData()
        {
            //빈값비교 NULL 체크
            //if (string.IsNullOrEmpty(TxtNames.Text) || CboBook.SelectedIndex < 1)
            //{
            //    MetroMessageBox.Show(this, "빈값은 넣을수 없습니다.", "오류",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (myMode == BaseMode.NONE)
            {
                MetroMessageBox.Show(this, "신규등록시 신규버튼을 눌러주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (myMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE rentaltbl " +
                                          "   SET memberIdx = @memberIdx " +
                                          "     , bookIdx = @bookIdx " +
                                          "     , rentalDate = @rentalDate " +
                                          "     , returnDate = @returnDate " +
                                          " WHERE Idx = @Idx ";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO rentaltbl " +
                                          "( " +
                                          "     memberIdx, " +
                                          "     bookIdx, " +
                                          "     rentalDate, " +
                                          "     returnDate "+
                                          ") " +
                                          "     VALUES " +
                                          "( " +
                                          "     @memberIdx, " +
                                          "     @bookIdx, " +
                                          "     @rentalDate, " +
                                          "     @returnDate " +
                                          ") ";


                    }

                    MySqlParameter paramMemberIdx = new MySqlParameter("@memberIdx", MySqlDbType.Int32)
                    {
                        Value = CboMember.SelectedValue
                    };
                    cmd.Parameters.Add(paramMemberIdx);

                    MySqlParameter parambookIdx = new MySqlParameter("@bookIdx", MySqlDbType.Int32)
                    {
                        Value = CboBook.SelectedValue
                    };
                    cmd.Parameters.Add(parambookIdx);
                    MySqlParameter paramRentalDate = new MySqlParameter("@rentalDate", MySqlDbType.Date)
                    {
                        Value = DtpRentalDate.Value
                    };
                    cmd.Parameters.Add(paramRentalDate);



                    MySqlParameter paramRetrunDate = new MySqlParameter("@returnDate", MySqlDbType.Date);

                    if (myMode == BaseMode.INSERT) paramRetrunDate.Value = null;
                    else paramRetrunDate.Value = DtpReturnDate.Value;
                   
                    cmd.Parameters.Add(paramRetrunDate);

                    if (myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paramIdx = new MySqlParameter("@Idx", MySqlDbType.Int32)
                        {
                            Value = TxtIdx.Text
                        };
                        cmd.Parameters.Add(paramIdx);
                    }
                    var result = cmd.ExecuteNonQuery();

                    if (myMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규입력되었습니다.", "신규입력");
                    }
                    else if (myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정되었습니다.", "업데이트");
                    }

                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러발생 {ex.Message}", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateData();
            }

        }
        #endregion
        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
        private void BtlNew_Click(object sender, EventArgs e)
        {
            IninControls();
            myMode = BaseMode.INSERT; //신규입력 모드
        }

        private void BtlSave_Click(object sender, EventArgs e)
        {
            SaveData();
            IninControls();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            IninControls();
        }


        private void GrdRentalTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                CboMember.SelectedValue = data.Cells[6].Value.ToString();
                CboBook.SelectedValue = data.Cells[7].Value.ToString();
                DtpRentalDate.Value = DateTime.Parse(data.Cells[4].Value.ToString());

                if(string.IsNullOrEmpty(data.Cells[5].Value.ToString()) != true)
                {
                    DtpReturnDate.CustomFormat = "yyyy-MM-dd";
                    DtpReturnDate.Format = DateTimePickerFormat.Custom;
                    DtpReturnDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());
                }
                else
                {
                    DtpReturnDate.CustomFormat = " ";
                    DtpReturnDate.Format = DateTimePickerFormat.Custom;
                }

                myMode = BaseMode.UPDATE;

            }
        }

        private void DtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            DtpReturnDate.CustomFormat = "yyyy-MM-dd";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
        }

        private void BtnExcelExport_Click(object sender, EventArgs e)
        {
            IWorkbook workbook = new XSSFWorkbook();//xlsx HSSFWorkbook(); //xls
            ISheet sheet1 = workbook.CreateSheet("Sheet1");
            sheet1.CreateRow(0).CreateCell(0).SetCellValue("Rental Book Data");
            int x = 1;

            DataSet ds = GrdRentalTbl.DataSource as DataSet;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                IRow row = sheet1.CreateRow(i);
                for (int j = 0; j < ds.Tables[0].Rows[0].ItemArray.Length; j++)
                {
                    if(j==4 || j == 5)
                    {
                        var value = string.IsNullOrEmpty(ds.Tables[0].Rows[i].ItemArray[j].ToString()) ?
                            "" : ds.Tables[0].Rows[i].ItemArray[j].ToString().Substring(0, 10);
                        row.CreateCell(j).SetCellValue(value);
                    }
                    else if (j > 5)
                    {
                        break;
                    }
                    else
                    {
                        row.CreateCell(j).SetCellValue(ds.Tables[0].Rows[i].ItemArray[j].ToString());
                    }
                }
            }
            FileStream file = File.Create(Environment.CurrentDirectory+$@"\export.xlsx");
            workbook.Write(file);
            file.Close();

            MessageBox.Show("Export done!!");
        }
    }
}
