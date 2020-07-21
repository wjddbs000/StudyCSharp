using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp2020.Subitems
{
    public partial class MemberMngForm : MetroForm
    {
        #region 멤버변수 영역
        BaseMode myMode = BaseMode.NONE;
        readonly string strTblName = "memberTbl";
        #endregion
        #region 생성자 영역
        public MemberMngForm()
        {
            InitializeComponent();
        }
        #endregion
        #region 폼로드 영역
        private void MemberMngForm_Load(object sender, EventArgs e)
        {
            UpdateDivision();
            UpdateData();

            IninControls();
        }
        #endregion
        private void UpdateDivision()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Names,Levels FROM membertbl ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", "");
                while (reader.Read())
                {
                    if (temps.ContainsKey(reader[1].ToString()) == false)
                        temps.Add(reader[1].ToString(), reader[0].ToString());
                }
                CboLevel.DataSource = new BindingSource(temps, null);
                CboLevel.DisplayMember = "key";
                CboLevel.ValueMember = "Value";
                CboLevel.SelectedIndex = 0;
            }
        }
        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Idx, " +
                                   "       Names, " +
                                   "       Levels, " +
                                   "       Addr, " +
                                   "       Mobile, " +
                                   "       Email " +
                                   "  FROM membertbl ";

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
        private void SetColumHeaders()
        {
            DataGridViewColumn column;
            column = GrdBooksTbl.Columns[0];
            column.Width = 40;
            column.HeaderText = "번호";

            column = GrdBooksTbl.Columns[1];
            column.Width = 70;
            column.HeaderText = "이름";

            column = GrdBooksTbl.Columns[2];
            column.Width = 40;
            column.HeaderText = "레벨";

            column = GrdBooksTbl.Columns[3];
            column.Width = 110;
            column.HeaderText = "주소";

            column = GrdBooksTbl.Columns[4];
            column.Width = 110;
            column.HeaderText = "모바일";

            column = GrdBooksTbl.Columns[5];
            column.Width = 110;
            column.HeaderText = "이메일";

        }
        private void IninControls()
        {
            TxtIdx.Text = TxtNames.Text = "";
            TxtAddr.Text = TxtMobile.Text = TxtEmail.Text = string.Empty;
            CboLevel.SelectedIndex = 0;
            TxtIdx.ReadOnly = true;
            TxtIdx.Focus();

            myMode = BaseMode.NONE;
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
        private void SaveData()
        {
            //빈값비교 NULL 체크
            if (string.IsNullOrEmpty(TxtNames.Text) || CboLevel.SelectedIndex < 1)
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
                        cmd.CommandText = "UPDATE membertbl " +
                                          "   SET " +
                                          "       Names = @Names, " +
                                          "       Levels = @Levels, " +
                                          "       Addr = @Addr, " +
                                          "       Mobile = @Mobile, " +
                                          "       Email = @Email, " +
                                          " WHERE Idx = @Idx ";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO membertbl " +
                                            "       (" +
                                            "       Names, " +
                                            "       Levels, " +
                                            "       Addr, " +
                                            "       Mobile, " +
                                            "       Email) " +
                                            "       VALUES " +
                                            "       (@Names, " +
                                            "       @Levels, " +
                                            "       @Addr, " +
                                            "       @Mobile, " +
                                            "       @Email)  ";

                    }

                    MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45)
                    {
                        Value = TxtNames.Text
                    };
                    cmd.Parameters.Add(paramNames);
                    MySqlParameter paramLevels = new MySqlParameter("@Levels", MySqlDbType.VarChar, 1)
                    {
                        Value = CboLevel.SelectedValue
                    };
                    cmd.Parameters.Add(paramLevels);
                    MySqlParameter paramAddr = new MySqlParameter("@Addr", MySqlDbType.VarChar, 100)
                    {
                        Value = TxtAddr.Text
                    };
                    cmd.Parameters.Add(paramAddr);
                    MySqlParameter paramMobile = new MySqlParameter("@Mobile", MySqlDbType.VarChar,13)
                    {
                        Value = TxtMobile.Text
                    };
                    cmd.Parameters.Add(paramMobile);
                    MySqlParameter paramEmail = new MySqlParameter("@Email", MySqlDbType.VarChar, 50)
                    {
                        Value = TxtEmail.Text
                    };
                    cmd.Parameters.Add(paramEmail);

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
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            IninControls();
        }

        private void GrdBooksTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                //로맨스,추리등 디스플레이되는 글자로 인덱스 찾기
                CboLevel.SelectedIndex = CboLevel.FindString(data.Cells[2].Value.ToString());
                //코드값을 그대로 할당하는 방법
                //CboLevel.SelectedValue = data.Cells[2].Value.ToString();
                TxtAddr.Text = data.Cells[3].Value.ToString();
                TxtMobile.Text = data.Cells[4].Value.ToString();
                TxtEmail.Text = data.Cells[5].Value.ToString();

                TxtNames.Focus();

                myMode = BaseMode.UPDATE;

            }
        }
    }
}
