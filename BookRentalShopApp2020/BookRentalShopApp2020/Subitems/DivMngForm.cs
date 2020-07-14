using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace BookRentalShopApp2020.Subitems
{
    public partial class DivMngForm : MetroForm
    {
        readonly string strTblName = "divTbl";
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
                adapter.Fill(ds, "divTbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = strTblName;
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtlNew_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
