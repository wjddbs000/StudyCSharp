using System;
using System.Windows.Forms;
using BookRentalShopApp2020.Subitems;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShopApp2020
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.ShowDialog();

            LbUserId.Text = $"LOGIN : {Commons.USERID}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result ==DialogResult.Yes) //프로그램 종료
            {
                e.Cancel=false;
                Environment.Exit(0);//완전종료
            }
            else //종료안함
            {
                e.Cancel = true;
            }
        }



        private void MnuItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MnuItemMng_Click(object sender, EventArgs e)
        {
            DivMngForm form = new DivMngForm();
            ShowFormControl(form,"구분코드 관리");
        }

        private void MnuItemBooksMng_Click(object sender, EventArgs e)
        {
            BookMngForm form = new BookMngForm();
            ShowFormControl(form,"도서관리");
        }
        private void 대여관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalMngForm form = new RentalMngForm();
            ShowFormControl(form, "대여관리");
        }
        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ShowFormControl(Form form,string title)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Text = title;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void MnuItemMemberMng_Click(object sender, EventArgs e)
        {
            MemberMngForm form = new MemberMngForm();
            ShowFormControl(form, "회원관리");
        }
    }
}
