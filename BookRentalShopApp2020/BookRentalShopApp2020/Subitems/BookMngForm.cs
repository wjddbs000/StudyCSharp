using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BookRentalShopApp2020.Subitems
{
    public partial class BookMngForm : MetroForm
    {
        readonly string strTblName = "booksTbl";

        BaseMode myMode = BaseMode.NONE;
        public BookMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            UpdateDivision();
            UpdateData();
            
            IninControls();
        }

        private void UpdateDivision()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Division,Names FROM divtbl ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택","");
                while (reader.Read())
                {
                    temps.Add(reader[1].ToString(),reader[0].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "key";
                CboDivision.ValueMember = "Value";
                CboDivision.SelectedIndex = 0;
            }

        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT b.Idx, " +
                                   "       b.Author, " +
                                   "       b.Division, " +
                                   "       d.Names AS DivisionName, " +
                                   "       b.Names, " +
                                   "       b.ReleaseDate, " +
                                   "       b.ISBN, " +
                                   "       b.Price " +
                                   "  FROM bookstbl AS b " +
                                   " INNER JOIN divtbl AS d " +
                                   "    ON b.Division = d.Division " +
                                   " ORDER BY b.Idx ASC ";



                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = strTblName;
            }
            SetColumHeaders();
        }
        /// <summary>
        /// DB업데이트 및 입력 처리
        /// </summary>
        private void SaveData()
        {
            //빈값비교 NULL 체크
            if (string.IsNullOrEmpty(TxtAuthor.Text)||
                  CboDivision.SelectedIndex<1||
                  string.IsNullOrEmpty(TxtNames.Text)||
                  string.IsNullOrEmpty(TxtIsbn.Text))

            {
                MetroMessageBox.Show(this, "빈값은 넣을수 없습니다.", "오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                        cmd.CommandText = "UPDATE bookstbl " +
                                          "   SET Author = @Author, " +
                                          "       Division = @Division, " +
                                          "       Names = @Names, " +
                                          "       ReleaseDate = @ReleaseDate, " +
                                          "       ISBN = @ISBN, " +
                                          "       Price = @Price " +
                                          " WHERE Idx = @Idx ";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO bookstbl " +
                                            "       (Author, " +
                                            "       Division, " +
                                            "       Names, " +
                                            "       ReleaseDate, " +
                                            "       ISBN, " +
                                            "       Price) " +
                                            "       VALUES " +
                                            "       (@Author, " +
                                            "       @Division, " +
                                            "       @Names," +
                                            "       @ReleaseDate, " +
                                            "       @ISBN, " +
                                            "       @Price) ";

                    }

                    MySqlParameter paramAuthor = new MySqlParameter("@Author", MySqlDbType.VarChar, 45)
                    {
                        Value = TxtAuthor.Text
                    };
                    cmd.Parameters.Add(paramAuthor);
                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 4)
                    {
                        Value = CboDivision.SelectedValue
                    };
                    cmd.Parameters.Add(paramDivision);
                    MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 100)
                    {
                        Value = TxtNames.Text
                    };
                    cmd.Parameters.Add(paramNames);
                    MySqlParameter paramReleaseDate = new MySqlParameter("@ReleaseDate", MySqlDbType.Date)
                    {
                        Value = DtpReleaseData.Value
                    };
                    cmd.Parameters.Add(paramReleaseDate);
                    MySqlParameter paramISBN = new MySqlParameter("@ISBN", MySqlDbType.VarChar, 13)
                    {
                        Value = TxtIsbn.Text
                    };
                    cmd.Parameters.Add(paramISBN);
                    MySqlParameter paramPrice = new MySqlParameter("@Price", MySqlDbType.Decimal)
                    {
                        Value = TxtPrice.Text
                    };
                    cmd.Parameters.Add(paramPrice);
                    if (myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paramIdx = new MySqlParameter("@Idx", MySqlDbType.Int32)
                        {
                            Value = TxtIdx.Text
                        };
                        cmd.Parameters.Add(paramIdx);
                    }
                    var result = cmd.ExecuteNonQuery();

                    if (myMode==BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this,$"{result}건이 신규입력되었습니다.", "신규입력");
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

        private void SetColumHeaders()
        {
            DataGridViewColumn column;
            column = GrdBooksTbl.Columns[0];
            column.Width = 50;
            column.HeaderText = "번호";

            column = GrdBooksTbl.Columns[1];
            column.Width = 150;
            column.HeaderText = "저자명";

            column = GrdBooksTbl.Columns[2]; //구분코드명
            column.Visible = false;

            column = GrdBooksTbl.Columns[3];
            column.Width = 150;
            column.HeaderText = "장르";

            column = GrdBooksTbl.Columns[4];
            column.Width = 150;
            column.HeaderText = "이름";

            column = GrdBooksTbl.Columns[5];
            column.Width = 150;
            column.HeaderText = "출간일";

            column = GrdBooksTbl.Columns[6];
            column.Width = 150;
            column.HeaderText = "ISBN";

            column = GrdBooksTbl.Columns[7];
            column.Width = 150;
            column.HeaderText = "가격";

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(myMode != BaseMode.UPDATE)
            {
                MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요", "알림");
                return;
            }
            myMode = BaseMode.DELETE;
            SaveData();
            IninControls();
        }

        private void IninControls()
        {
            TxtIdx.Text = TxtAuthor.Text = "";
            TxtIsbn.Text = TxtNames.Text = TxtPrice.Text = string.Empty;
            CboDivision.SelectedIndex = 0;
            TxtIdx.ReadOnly = true;
            TxtIdx.Focus();

            DtpReleaseData.CustomFormat = "yyyy-MM-dd";
            DtpReleaseData.Format = DateTimePickerFormat.Custom;
            DtpReleaseData.Value = DateTime.Now;

            myMode = BaseMode.NONE;

            ////콤보박스 데이터바인딩
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("선택", "00");
            //dic.Add("서울특별시", "11");
            //dic.Add("부산광역시", "21");
            //dic.Add("대구광역시", "22");
            //dic.Add("인천광역시", "23");
            //dic.Add("광주광역시", "24");
            //dic.Add("대전광역시", "25");

            //CboDivision.DataSource = new BindingSource(dic,null);
            //CboDivision.DisplayMember = "key";
            //CboDivision.ValueMember = "Value";

        }

        #region 삭제메소드 주석처리
        //private void DeleteProcess()
        //{
        //    try
        //    {
        //        using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
        //        {
        //            conn.Open();
        //            MySqlCommand cmd = new MySqlCommand();
        //            cmd.Connection = conn;
        //            cmd.CommandText = " DELETE FROM divtbl " +
        //                               " WHERE Division = @Division ";
        //            MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);
        //            paramDivision.Value = TxtDivision.Text;
        //            cmd.Parameters.Add(paramDivision);

        //            var result = cmd.ExecuteNonQuery();
        //            MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MetroMessageBox.Show(this, $"에러발생 {ex.Message}", "에러",
        //           MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        UpdateData();
        //    }
        //}
        #endregion


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

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1) { 
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtAuthor.Text = data.Cells[1].Value.ToString();
                //로맨스,추리등 디스플레이되는 글자로 인덱스 찾기
                //CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString());
                //코드값을 그대로 할당하는 방법
                CboDivision.SelectedValue = data.Cells[2].Value.ToString();
                TxtNames.Text = data.Cells[4].Value.ToString();
                //TODO 출간일 날짜 Cells[5]
                DtpReleaseData.CustomFormat = "yyyy-MM-dd";
                DtpReleaseData.Format = DateTimePickerFormat.Custom;
                DtpReleaseData.Value = DateTime.Parse(data.Cells[5].Value.ToString());

                TxtIsbn.Text = data.Cells[6].Value.ToString();
                TxtPrice.Text = data.Cells[7].Value.ToString();

                TxtIdx.ReadOnly=true;
                TxtAuthor.Focus();

                myMode = BaseMode.UPDATE;

            }
        }

       
    }
}
