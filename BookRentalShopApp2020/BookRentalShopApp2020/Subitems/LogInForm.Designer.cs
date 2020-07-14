namespace BookRentalShopApp2020.Subitems
{
    partial class LogInForm
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
            this.TxtUserID = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtlOk = new MetroFramework.Controls.MetroButton();
            this.BtlCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // TxtUserID
            // 
            // 
            // 
            // 
            this.TxtUserID.CustomButton.Image = null;
            this.TxtUserID.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.TxtUserID.CustomButton.Name = "";
            this.TxtUserID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserID.CustomButton.TabIndex = 1;
            this.TxtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserID.CustomButton.UseSelectable = true;
            this.TxtUserID.CustomButton.Visible = false;
            this.TxtUserID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtUserID.Lines = new string[0];
            this.TxtUserID.Location = new System.Drawing.Point(211, 100);
            this.TxtUserID.MaxLength = 12;
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.PasswordChar = '\0';
            this.TxtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserID.SelectedText = "";
            this.TxtUserID.SelectionLength = 0;
            this.TxtUserID.SelectionStart = 0;
            this.TxtUserID.ShortcutsEnabled = true;
            this.TxtUserID.Size = new System.Drawing.Size(187, 28);
            this.TxtUserID.TabIndex = 0;
            this.TxtUserID.UseSelectable = true;
            this.TxtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserID_KeyPress);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(211, 153);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(187, 28);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // BtlOk
            // 
            this.BtlOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtlOk.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtlOk.Location = new System.Drawing.Point(211, 203);
            this.BtlOk.Name = "BtlOk";
            this.BtlOk.Size = new System.Drawing.Size(84, 28);
            this.BtlOk.TabIndex = 2;
            this.BtlOk.Text = "OK";
            this.BtlOk.UseSelectable = true;
            this.BtlOk.Click += new System.EventHandler(this.BtlOk_Click);
            // 
            // BtlCancel
            // 
            this.BtlCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtlCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtlCancel.Location = new System.Drawing.Point(314, 203);
            this.BtlCancel.Name = "BtlCancel";
            this.BtlCancel.Size = new System.Drawing.Size(84, 28);
            this.BtlCancel.TabIndex = 3;
            this.BtlCancel.Text = "CANCEL";
            this.BtlCancel.UseSelectable = true;
            this.BtlCancel.Click += new System.EventHandler(this.BtlCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(89, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 23);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "ID :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(89, 153);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 23);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "PASSWORD :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 294);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtlCancel);
            this.Controls.Add(this.BtlOk);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.Resizable = false;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox TxtUserID;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroButton BtlOk;
        private MetroFramework.Controls.MetroButton BtlCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}