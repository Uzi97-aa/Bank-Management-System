namespace BankMangmentSystem.Account
{
    partial class frmAddUpdateAccount
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
            this.btnNext = new FastUI.FastUILibrary.Components.FuiButton();
            this.ctrlAccount1 = new BankMangmentSystem.Account.Controls.ctrlAccount();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnNext.BorderWidth = 1.2F;
            this.btnNext.ControlHeight = 36;
            this.btnNext.ControlWidth = 125;
            this.btnNext.CornerRadius = 8F;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnNext.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNext.FontSize = 10.5F;
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNext.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnNext.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnNext.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNext.Location = new System.Drawing.Point(419, 477);
            this.btnNext.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnNext.MoveTextHorizontal = 0;
            this.btnNext.MoveTextVertical = 0;
            this.btnNext.Name = "btnNext";
            this.btnNext.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnNext.PressDepth = 2;
            this.btnNext.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnNext.Size = new System.Drawing.Size(125, 36);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "NEXT";
            this.btnNext.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnNext.Theme = "Windows11";
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlAccount1
            // 
            this.ctrlAccount1.BackColor = System.Drawing.Color.Bisque;
            this.ctrlAccount1.Location = new System.Drawing.Point(-3, 2);
            this.ctrlAccount1.Name = "ctrlAccount1";
            this.ctrlAccount1.Size = new System.Drawing.Size(960, 454);
            this.ctrlAccount1.TabIndex = 2;
            this.ctrlAccount1.Load += new System.EventHandler(this.ctrlAccount1_Load);
            // 
            // frmAddUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 531);
            this.Controls.Add(this.ctrlAccount1);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddUpdateAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FastUI.FastUILibrary.Components.FuiButton btnNext;
        private Controls.ctrlAccount ctrlAccount1;
    }
}