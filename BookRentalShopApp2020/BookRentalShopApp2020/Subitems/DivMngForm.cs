using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookRentalShopApp2020.Subitems
{
    public partial class DivMngForm : MetroForm
    {
        readonly string strTblName = "divtbl";

        BaseMode myMode = BaseMode.NONE;
        public DivMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Division,Names FROM {strTblName} ";
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = strTblName;
            }
            SetColumHeaders();
        }
        /// <summary>
        /// DB업데이트 및 입력 처리
        /// </summary>
        private void SaveData()
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) ||
                  string.IsNullOrEmpty(TxtNames.Text))
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
                        cmd.CommandText = "UPDATE divtbl " +
                                          "   SET Names = @Names " +
                                          " WHERE Division = @Division ";
                    }
                    else if(myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = " INSERT INTO "+
                                          " divtbl (Division,Names) "+
                                          " VALUES (@Division, @Names) ";
                    }
                    else if(myMode == BaseMode.DELETE)
                    {
                        cmd.CommandText = " DELETE FROM divtbl " +
                                       " WHERE Division = @Division ";
                    }
                    if(myMode == BaseMode.INSERT || myMode == BaseMode.UPDATE) { 
                        MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);
                        paramNames.Value = TxtNames.Text;
                        cmd.Parameters.Add(paramNames);
                    }
                    MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);
                    paramDivision.Value = TxtDivision.Text;
                    cmd.Parameters.Add(paramDivision);

                    var result = cmd.ExecuteNonQuery();

                    if (myMode==BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this,$"{result}건이 신규입력되었습니다.", "신규입력");
                    }
                    else if (myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정되었습니다.", "업데이트");
                    }
                    else if (myMode == BaseMode.DELETE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
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
            column = GrdDivTbl.Columns[0];
            column.Width = 100;
            column.HeaderText = "구분코드";

            column = GrdDivTbl.Columns[1];
            column.Width = 150;
            column.HeaderText = "이름";

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
            TxtDivision.Text = TxtNames.Text = "";
            TxtDivision.Focus();
            myMode = BaseMode.NONE;


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
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.ReadOnly = false;

            TxtDivision.Focus();

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
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
          
                TxtDivision.ReadOnly=true;

                myMode = BaseMode.UPDATE;

            }
        }

        
    }
}
