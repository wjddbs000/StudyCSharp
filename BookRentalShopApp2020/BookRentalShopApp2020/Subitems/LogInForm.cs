using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp2020.Subitems
{
    public partial class LogInForm : MetroForm
    {
        

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BtlOk_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            // 빈값비교 처리
            if (string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디나 패스워드를 입력하세요!", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUserID.Focus();
                return;
            }
            //실제 DB처리
            string resultId = string.Empty; // ""
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
                {
                    conn.Open();
                    //MetroMessageBox.Show(this, $"DB접속성공!!");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID FROM userTBL " +
                                       "WHERE userID = @userID " +
                                        " AND password = @password ";
                    MySqlParameter paramUserID = new MySqlParameter("@userID", MySqlDbType.VarChar, 12);
                    paramUserID.Value = TxtUserID.Text.Trim();
                    MySqlParameter paramPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
                    paramPassword.Value = TxtPassword.Text.Trim();

                    cmd.Parameters.Add(paramUserID);
                    cmd.Parameters.Add(paramPassword);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (!reader.HasRows)
                    {
                        MetroMessageBox.Show(this,"아이디나 패스워드를 정확히 입력하세요","로그인 실패",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        TxtUserID.Text = TxtPassword.Text = string.Empty;
                        TxtUserID.Focus();
                        return;

                    }
                    else
                    {
                        resultId = reader["userID"] != null ? reader["userID"].ToString() : string.Empty;
                        MetroMessageBox.Show(this, $"{resultId} 로그인 성공");
                    }

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"DB접속에러 : {ex.Message}", "로그인에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(resultId))
            {
                MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserID.Text = TxtPassword.Text = string.Empty;
                TxtUserID.Focus();
                return;
            }
            else
            {
                this.Close();
            }

        }

        private void BtlCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtlOk_Click(sender,new EventArgs());
            }
        }
    }
}
