namespace BookRentalShopApp2020
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemMng = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemBooksMng = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대여관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemMemberMng = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.LbUserId = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리MToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리MToolStripMenuItem
            // 
            this.관리MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemMng,
            this.MnuItemBooksMng,
            this.사용자관리ToolStripMenuItem,
            this.대여관리ToolStripMenuItem,
            this.MnuItemMemberMng,
            this.toolStripMenuItem1,
            this.MnuItemExit});
            this.관리MToolStripMenuItem.Name = "관리MToolStripMenuItem";
            this.관리MToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.관리MToolStripMenuItem.Text = "관리(M)";
            // 
            // MnuItemMng
            // 
            this.MnuItemMng.Name = "MnuItemMng";
            this.MnuItemMng.Size = new System.Drawing.Size(168, 22);
            this.MnuItemMng.Text = "코드관리(C)";
            this.MnuItemMng.Click += new System.EventHandler(this.MnuItemMng_Click);
            // 
            // MnuItemBooksMng
            // 
            this.MnuItemBooksMng.Name = "MnuItemBooksMng";
            this.MnuItemBooksMng.Size = new System.Drawing.Size(168, 22);
            this.MnuItemBooksMng.Text = "도서관리(B)";
            this.MnuItemBooksMng.Click += new System.EventHandler(this.MnuItemBooksMng_Click);
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.사용자관리ToolStripMenuItem.Text = "사용자관리";
            this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
            // 
            // 대여관리ToolStripMenuItem
            // 
            this.대여관리ToolStripMenuItem.Name = "대여관리ToolStripMenuItem";
            this.대여관리ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.대여관리ToolStripMenuItem.Text = "대여관리";
            this.대여관리ToolStripMenuItem.Click += new System.EventHandler(this.대여관리ToolStripMenuItem_Click);
            // 
            // MnuItemMemberMng
            // 
            this.MnuItemMemberMng.Name = "MnuItemMemberMng";
            this.MnuItemMemberMng.Size = new System.Drawing.Size(168, 22);
            this.MnuItemMemberMng.Text = "회원관리";
            this.MnuItemMemberMng.Click += new System.EventHandler(this.MnuItemMemberMng_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // MnuItemExit
            // 
            this.MnuItemExit.Name = "MnuItemExit";
            this.MnuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnuItemExit.Size = new System.Drawing.Size(168, 22);
            this.MnuItemExit.Text = "끝내기(X)";
            this.MnuItemExit.Click += new System.EventHandler(this.MnuItemExit_Click);
            // 
            // LbUserId
            // 
            this.LbUserId.AutoSize = true;
            this.LbUserId.Location = new System.Drawing.Point(262, 31);
            this.LbUserId.Name = "LbUserId";
            this.LbUserId.Size = new System.Drawing.Size(81, 19);
            this.LbUserId.TabIndex = 3;
            this.LbUserId.Text = "metroLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.LbUserId);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "BookRentalShop";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuItemMng;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MnuItemBooksMng;
        private System.Windows.Forms.ToolStripMenuItem MnuItemMemberMng;
        private System.Windows.Forms.ToolStripMenuItem 대여관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel LbUserId;
    }
}

