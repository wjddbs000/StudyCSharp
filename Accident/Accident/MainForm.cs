using MetroFramework.Forms;
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

namespace Accident
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient() { Encoding = Encoding.UTF8 };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/1262000/AccidentService"); // OpenAPI 기본
            str.Append("?serviceKey=UYRmIKAbAsL3%2B0xkSGRzTCKqwSg2%2FPE7V8M2h98JBt%2FkmioKZbm1DHLXqm1pdTr8Kw8g2rJqtInMEQVZDD8qnw%3D%3D"); // 인증키
            str.Append($"&secnNm={metroTextBox1.Text}"); // 검색어
            str.Append("&numOfRows=200"); // 읽어올 데이터수
            str.Append("&pageNo=1"); // 페이지번호

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            dataGridView1.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    dataGridView1.Rows.Add(
                        item["countryName"].InnerText, //주식발행일자 item["issuDt"].InnerText,//
                        item["news"].InnerText //한글종목명
                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(this, $"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
