namespace BookRentalShopApp2020.Subitems
{
    partial class RentalMngForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdRentalTbl = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.DtpReturnDate = new MetroFramework.Controls.MetroDateTime();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.CboMember = new System.Windows.Forms.ComboBox();
            this.CboBook = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtlSave = new MetroFramework.Controls.MetroButton();
            this.BtlNew = new MetroFramework.Controls.MetroButton();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnExcelExport = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRentalTbl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdRentalTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 1;
            // 
            // GrdRentalTbl
            // 
            this.GrdRentalTbl.AllowUserToAddRows = false;
            this.GrdRentalTbl.AllowUserToDeleteRows = false;
            this.GrdRentalTbl.AllowUserToResizeRows = false;
            this.GrdRentalTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdRentalTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdRentalTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdRentalTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRentalTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdRentalTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdRentalTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdRentalTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRentalTbl.EnableHeadersVisualStyles = false;
            this.GrdRentalTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdRentalTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdRentalTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdRentalTbl.Name = "GrdRentalTbl";
            this.GrdRentalTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRentalTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdRentalTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdRentalTbl.RowTemplate.Height = 23;
            this.GrdRentalTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdRentalTbl.Size = new System.Drawing.Size(374, 370);
            this.GrdRentalTbl.Style = MetroFramework.MetroColorStyle.Green;
            this.GrdRentalTbl.TabIndex = 0;
            this.GrdRentalTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdRentalTbl_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExcelExport);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.DtpReturnDate);
            this.groupBox1.Controls.Add(this.DtpRentalDate);
            this.groupBox1.Controls.Add(this.CboMember);
            this.groupBox1.Controls.Add(this.CboBook);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtlSave);
            this.groupBox1.Controls.Add(this.BtlNew);
            this.groupBox1.Controls.Add(this.TxtIdx);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // BtnDelete
            // 
            this.BtnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDelete.Location = new System.Drawing.Point(46, 233);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(69, 27);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Location = new System.Drawing.Point(137, 187);
            this.DtpReturnDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(185, 29);
            this.DtpReturnDate.TabIndex = 4;
            this.DtpReturnDate.ValueChanged += new System.EventHandler(this.DtpReturnDate_ValueChanged);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.Location = new System.Drawing.Point(137, 152);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(185, 29);
            this.DtpRentalDate.TabIndex = 3;
            // 
            // CboMember
            // 
            this.CboMember.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CboMember.FormattingEnabled = true;
            this.CboMember.ItemHeight = 16;
            this.CboMember.Location = new System.Drawing.Point(137, 78);
            this.CboMember.Name = "CboMember";
            this.CboMember.Size = new System.Drawing.Size(185, 24);
            this.CboMember.TabIndex = 1;
            // 
            // CboBook
            // 
            this.CboBook.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CboBook.FormattingEnabled = true;
            this.CboBook.ItemHeight = 16;
            this.CboBook.Location = new System.Drawing.Point(137, 117);
            this.CboBook.Name = "CboBook";
            this.CboBook.Size = new System.Drawing.Size(185, 24);
            this.CboBook.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCancel.Location = new System.Drawing.Point(253, 233);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(69, 27);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtlSave
            // 
            this.BtlSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtlSave.Location = new System.Drawing.Point(184, 233);
            this.BtlSave.Name = "BtlSave";
            this.BtlSave.Size = new System.Drawing.Size(69, 27);
            this.BtlSave.TabIndex = 7;
            this.BtlSave.Text = "저장";
            this.BtlSave.UseSelectable = true;
            this.BtlSave.Click += new System.EventHandler(this.BtlSave_Click);
            // 
            // BtlNew
            // 
            this.BtlNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtlNew.Location = new System.Drawing.Point(115, 233);
            this.BtlNew.Name = "BtlNew";
            this.BtlNew.Size = new System.Drawing.Size(69, 27);
            this.BtlNew.TabIndex = 6;
            this.BtlNew.Text = "신규";
            this.BtlNew.UseSelectable = true;
            this.BtlNew.Click += new System.EventHandler(this.BtlNew_Click);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(137, 39);
            this.TxtIdx.MaxLength = 12;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(185, 25);
            this.TxtIdx.TabIndex = 0;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(30, 187);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "반납일 : ";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(30, 156);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "대여일 : ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(30, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "책 : ";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(30, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "회원 : ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(30, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "번호 : ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnExcelExport
            // 
            this.BtnExcelExport.Location = new System.Drawing.Point(137, 293);
            this.BtnExcelExport.Name = "BtnExcelExport";
            this.BtnExcelExport.Size = new System.Drawing.Size(152, 41);
            this.BtnExcelExport.TabIndex = 9;
            this.BtnExcelExport.Text = "BtnExcelExport";
            this.BtnExcelExport.UseSelectable = true;
            this.BtnExcelExport.Click += new System.EventHandler(this.BtnExcelExport_Click);
            // 
            // RentalMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RentalMngForm";
            this.Text = "RentalMngForm";
            this.Load += new System.EventHandler(this.MemberMngForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRentalTbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdRentalTbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboBook;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtlSave;
        private MetroFramework.Controls.MetroButton BtlNew;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DtpReturnDate;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private System.Windows.Forms.ComboBox CboMember;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton BtnExcelExport;
    }
}