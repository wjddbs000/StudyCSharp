namespace BookRentalShopApp2020.Subitems
{
    partial class BookMngForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdBooksTbl = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpReleaseData = new MetroFramework.Controls.MetroDateTime();
            this.CboDivision = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtlSave = new MetroFramework.Controls.MetroButton();
            this.BtlNew = new MetroFramework.Controls.MetroButton();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtIsbn = new MetroFramework.Controls.MetroTextBox();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdBooksTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(728, 370);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdBooksTbl
            // 
            this.GrdBooksTbl.AllowUserToAddRows = false;
            this.GrdBooksTbl.AllowUserToDeleteRows = false;
            this.GrdBooksTbl.AllowUserToResizeRows = false;
            this.GrdBooksTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBooksTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdBooksTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdBooksTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdBooksTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdBooksTbl.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdBooksTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdBooksTbl.EnableHeadersVisualStyles = false;
            this.GrdBooksTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdBooksTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBooksTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdBooksTbl.Name = "GrdBooksTbl";
            this.GrdBooksTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdBooksTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdBooksTbl.RowTemplate.Height = 23;
            this.GrdBooksTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdBooksTbl.Size = new System.Drawing.Size(360, 370);
            this.GrdBooksTbl.Style = MetroFramework.MetroColorStyle.Green;
            this.GrdBooksTbl.TabIndex = 0;
            this.GrdBooksTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpReleaseData);
            this.groupBox1.Controls.Add(this.CboDivision);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtlSave);
            this.groupBox1.Controls.Add(this.BtlNew);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.TxtIsbn);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.TxtAuthor);
            this.groupBox1.Controls.Add(this.TxtIdx);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // DtpReleaseData
            // 
            this.DtpReleaseData.Location = new System.Drawing.Point(137, 193);
            this.DtpReleaseData.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReleaseData.Name = "DtpReleaseData";
            this.DtpReleaseData.Size = new System.Drawing.Size(185, 29);
            this.DtpReleaseData.TabIndex = 4;
            // 
            // CboDivision
            // 
            this.CboDivision.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.ItemHeight = 16;
            this.CboDivision.Location = new System.Drawing.Point(137, 117);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(185, 24);
            this.CboDivision.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCancel.Location = new System.Drawing.Point(242, 317);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(69, 27);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtlSave
            // 
            this.BtlSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtlSave.Location = new System.Drawing.Point(173, 317);
            this.BtlSave.Name = "BtlSave";
            this.BtlSave.Size = new System.Drawing.Size(69, 27);
            this.BtlSave.TabIndex = 9;
            this.BtlSave.Text = "저장";
            this.BtlSave.UseSelectable = true;
            this.BtlSave.Click += new System.EventHandler(this.BtlSave_Click);
            // 
            // BtlNew
            // 
            this.BtlNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtlNew.Location = new System.Drawing.Point(104, 317);
            this.BtlNew.Name = "BtlNew";
            this.BtlNew.Size = new System.Drawing.Size(69, 27);
            this.BtlNew.TabIndex = 8;
            this.BtlNew.Text = "신규";
            this.BtlNew.UseSelectable = true;
            this.BtlNew.Click += new System.EventHandler(this.BtlNew_Click);
            // 
            // TxtPrice
            // 
            // 
            // 
            // 
            this.TxtPrice.CustomButton.Image = null;
            this.TxtPrice.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TxtPrice.CustomButton.Name = "";
            this.TxtPrice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrice.CustomButton.TabIndex = 1;
            this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrice.CustomButton.UseSelectable = true;
            this.TxtPrice.CustomButton.Visible = false;
            this.TxtPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPrice.Lines = new string[0];
            this.TxtPrice.Location = new System.Drawing.Point(137, 273);
            this.TxtPrice.MaxLength = 45;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.SelectionLength = 0;
            this.TxtPrice.SelectionStart = 0;
            this.TxtPrice.ShortcutsEnabled = true;
            this.TxtPrice.Size = new System.Drawing.Size(185, 25);
            this.TxtPrice.TabIndex = 6;
            this.TxtPrice.UseSelectable = true;
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIsbn
            // 
            // 
            // 
            // 
            this.TxtIsbn.CustomButton.Image = null;
            this.TxtIsbn.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TxtIsbn.CustomButton.Name = "";
            this.TxtIsbn.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtIsbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIsbn.CustomButton.TabIndex = 1;
            this.TxtIsbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIsbn.CustomButton.UseSelectable = true;
            this.TxtIsbn.CustomButton.Visible = false;
            this.TxtIsbn.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIsbn.Lines = new string[0];
            this.TxtIsbn.Location = new System.Drawing.Point(137, 234);
            this.TxtIsbn.MaxLength = 13;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.PasswordChar = '\0';
            this.TxtIsbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIsbn.SelectedText = "";
            this.TxtIsbn.SelectionLength = 0;
            this.TxtIsbn.SelectionStart = 0;
            this.TxtIsbn.ShortcutsEnabled = true;
            this.TxtIsbn.Size = new System.Drawing.Size(185, 25);
            this.TxtIsbn.TabIndex = 5;
            this.TxtIsbn.UseSelectable = true;
            this.TxtIsbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIsbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(137, 156);
            this.TxtNames.MaxLength = 100;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(185, 25);
            this.TxtNames.TabIndex = 3;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAuthor
            // 
            // 
            // 
            // 
            this.TxtAuthor.CustomButton.Image = null;
            this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TxtAuthor.CustomButton.Name = "";
            this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAuthor.CustomButton.TabIndex = 1;
            this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAuthor.CustomButton.UseSelectable = true;
            this.TxtAuthor.CustomButton.Visible = false;
            this.TxtAuthor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtAuthor.Lines = new string[0];
            this.TxtAuthor.Location = new System.Drawing.Point(137, 78);
            this.TxtAuthor.MaxLength = 45;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.PasswordChar = '\0';
            this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAuthor.SelectedText = "";
            this.TxtAuthor.SelectionLength = 0;
            this.TxtAuthor.SelectionStart = 0;
            this.TxtAuthor.ShortcutsEnabled = true;
            this.TxtAuthor.Size = new System.Drawing.Size(185, 25);
            this.TxtAuthor.TabIndex = 1;
            this.TxtAuthor.UseSelectable = true;
            this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(30, 273);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 20);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "가격 : ";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(30, 234);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "ISBN : ";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(30, 195);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 20);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "출간일 : ";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(30, 156);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "이름 : ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(30, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "구분코드 : ";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(30, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "저자 : ";
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
            // BookMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BookMngForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "BooksMngForm";
            this.Load += new System.EventHandler(this.DivMngForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdBooksTbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtlSave;
        private MetroFramework.Controls.MetroButton BtlNew;
        private MetroFramework.Controls.MetroTextBox TxtAuthor;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private MetroFramework.Controls.MetroTextBox TxtIsbn;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime DtpReleaseData;
        private System.Windows.Forms.ComboBox CboDivision;
    }
}