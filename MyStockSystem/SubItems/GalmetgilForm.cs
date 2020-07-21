using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyStockSystem.SubItems
{
    public partial class GalmetgilForm : MetroForm
    {
        public GalmetgilForm()
        {
            InitializeComponent();
        }

        private void GalmetgilForm_Load(object sender, EventArgs e)
        {
            DgvSearchItems.Font = new Font(@"NanumGothic", 9, FontStyle.Regular);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo"); // OpenAPI 기본
            str.Append("?serviceKey=UYRmIKAbAsL3%2B0xkSGRzTCKqwSg2%2FPE7V8M2h98JBt%2FkmioKZbm1DHLXqm1pdTr8Kw8g2rJqtInMEQVZDD8qnw%3D%3D"); // 인증키
            str.Append("&pageNo=1"); // 페이지번호
            str.Append("&numOfRows=10"); // 읽어올 데이터수
            str.Append("&resultType=json"); // 주식시장종류 11=유가증권

            string json = wc.DownloadString(str.ToString());
            JObject obj = JObject.Parse(json);

            obj.SelectToken("getGalmaetGilInfo.item").ToString();
            JArray items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());

            DgvSearchItems.Rows.Clear();

            foreach (var item in items)
            {
                // kosNm,kosType,kosTxt,img,txt1,title,txt2
                DgvSearchItems.Rows.Add(
                    $"{item.SelectToken("kosNm")}",
                    $"{item.SelectToken("kosType")}",
                    $"{item.SelectToken("kosTxt")}",
                    $"{item.SelectToken("img")}",
                    $"{item.SelectToken("txt1")}",
                    $"{item.SelectToken("title")}",
                    $"{item.SelectToken("txt2")}");
            }
            
            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }


        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();

            this.Close();
        }

        private void DgvSearchItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selvalue = DgvSearchItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            MessageBox.Show(selvalue);
            DownloadForm form = new DownloadForm();
            form.ParentUrl = selvalue;
            form.ShowDialog();
        }
    }
}
