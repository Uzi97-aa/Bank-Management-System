namespace BankMangmentSystem
{
    partial class frmLogin
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtUserName = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtPassword = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new FastUI.FastUILibrary.Components.FuiButton();
            this.btnClose = new FastUI.FastUILibrary.Components.FuiButton();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(479, 529);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.AllowSpace = true;
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtUserName.BorderWidth = 1.2F;
            this.txtUserName.CornerRadius = 6F;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FastText = "";
            this.txtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtUserName.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUserName.FontSize = 10.5F;
            this.txtUserName.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserName.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtUserName.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtUserName.Location = new System.Drawing.Point(582, 177);
            this.txtUserName.MoveTextHorizontal = 6;
            this.txtUserName.MoveTextVertical = 0;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Placeholder = "Enter Your User Name";
            this.txtUserName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtUserName.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtUserName.Size = new System.Drawing.Size(281, 49);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "fuiTextBox1";
            this.txtUserName.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtUserName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUserName.Theme = "Windows11";
            // 
            // txtPassword
            // 
            this.txtPassword.AllowSpace = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPassword.BorderWidth = 1.2F;
            this.txtPassword.CornerRadius = 6F;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FastText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtPassword.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPassword.FontSize = 10.5F;
            this.txtPassword.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPassword.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtPassword.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtPassword.Location = new System.Drawing.Point(582, 286);
            this.txtPassword.MoveTextHorizontal = 6;
            this.txtPassword.MoveTextVertical = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Placeholder = "Enter your Password";
            this.txtPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtPassword.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtPassword.Size = new System.Drawing.Size(281, 50);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "fuiTextBox2";
            this.txtPassword.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtPassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.Theme = "Windows11";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login to your account";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome To Your";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bank System";
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.Location = new System.Drawing.Point(628, 382);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(162, 29);
            this.chkRememberMe.TabIndex = 7;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnLogin.BorderWidth = 1.2F;
            this.btnLogin.ControlHeight = 36;
            this.btnLogin.ControlWidth = 125;
            this.btnLogin.CornerRadius = 8F;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnLogin.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnLogin.FontSize = 10.5F;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnLogin.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnLogin.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogin.Location = new System.Drawing.Point(653, 460);
            this.btnLogin.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnLogin.MoveTextHorizontal = 0;
            this.btnLogin.MoveTextVertical = 0;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnLogin.PressDepth = 2;
            this.btnLogin.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnLogin.Size = new System.Drawing.Size(125, 36);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnLogin.Theme = "Windows11";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnClose.BorderWidth = 1.2F;
            this.btnClose.ControlHeight = 36;
            this.btnClose.ControlWidth = 125;
            this.btnClose.CornerRadius = 8F;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnClose.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.FontSize = 10.5F;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnClose.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClose.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClose.Location = new System.Drawing.Point(760, 12);
            this.btnClose.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnClose.MoveTextHorizontal = 0;
            this.btnClose.MoveTextVertical = 0;
            this.btnClose.Name = "btnClose";
            this.btnClose.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnClose.PressDepth = 2;
            this.btnClose.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnClose.Size = new System.Drawing.Size(125, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnClose.Theme = "Windows11";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Image = global::BankMangmentSystem.Properties.Resources.jonathan_cooper_0O2Pp6_mOkY_unsplash;
            this.pbPicture.Location = new System.Drawing.Point(35, 76);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(418, 216);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pbPicture;
        private FastUI.FastUILibrary.Components.FuiTextBox txtUserName;
        private FastUI.FastUILibrary.Components.FuiTextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private FastUI.FastUILibrary.Components.FuiButton btnLogin;
        private FastUI.FastUILibrary.Components.FuiButton btnClose;
    }
}