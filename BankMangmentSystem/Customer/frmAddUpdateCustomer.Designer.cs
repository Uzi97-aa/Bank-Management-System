namespace BankMangmentSystem.Customer
{
    partial class frmAddUpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtbDate = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbGender = new FastUI.FastUILibrary.Components.FuiComboBox();
            this.txtFirstName = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtSecondName = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtThirdName = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtLastName = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtNationalID = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtEmail = new FastUI.FastUILibrary.Components.FuiEmail();
            this.txtPhone = new FastUI.FastUILibrary.Components.FuiPhoneDz();
            this.txtAddress = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.btnADD = new FastUI.FastUILibrary.Components.FuiButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNationalID);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtThirdName);
            this.groupBox1.Controls.Add(this.txtSecondName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.dtbDate);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Location = new System.Drawing.Point(42, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1408, 708);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtbDate
            // 
            this.dtbDate.Location = new System.Drawing.Point(1064, 317);
            this.dtbDate.MaxDate = new System.DateTime(2026, 7, 19, 0, 0, 0, 0);
            this.dtbDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtbDate.Name = "dtbDate";
            this.dtbDate.Size = new System.Drawing.Size(336, 22);
            this.dtbDate.TabIndex = 48;
            this.dtbDate.Value = new System.DateTime(2026, 7, 19, 0, 0, 0, 0);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(887, 53);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(274, 34);
            this.lblCustomer.TabIndex = 47;
            this.lblCustomer.Text = "Customer ID : ";
            this.lblCustomer.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // cbGender
            // 
            this.cbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbGender.BorderWidth = 1.2F;
            this.cbGender.CornerRadius = 6F;
            this.cbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbGender.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbGender.FocusFillColor = System.Drawing.Color.White;
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGender.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbGender.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbGender.Items = new string[] {
        "Male",
        "Female"};
            this.cbGender.Location = new System.Drawing.Point(1064, 506);
            this.cbGender.Name = "cbGender";
            this.cbGender.Placeholder = "Select";
            this.cbGender.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cbGender.Size = new System.Drawing.Size(336, 36);
            this.cbGender.TabIndex = 37;
            this.cbGender.Text = "fuiComboBox1";
            this.cbGender.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbGender.Theme = "Windows11";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AllowSpace = true;
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtFirstName.BorderWidth = 1.2F;
            this.txtFirstName.CornerRadius = 6F;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FastText = "";
            this.txtFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFirstName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFirstName.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFirstName.FontSize = 10.5F;
            this.txtFirstName.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFirstName.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtFirstName.InputType = FastUI.FastUILibrary.Core.FastInputType.LettersOnly;
            this.txtFirstName.Location = new System.Drawing.Point(648, 127);
            this.txtFirstName.MoveTextHorizontal = 6;
            this.txtFirstName.MoveTextVertical = 0;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Placeholder = "First Name";
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFirstName.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFirstName.Size = new System.Drawing.Size(336, 34);
            this.txtFirstName.TabIndex = 57;
            this.txtFirstName.Text = "fuiTextBox1";
            this.txtFirstName.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtFirstName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFirstName.Theme = "Windows11";
            // 
            // txtSecondName
            // 
            this.txtSecondName.AllowSpace = true;
            this.txtSecondName.BackColor = System.Drawing.Color.Transparent;
            this.txtSecondName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtSecondName.BorderWidth = 1.2F;
            this.txtSecondName.CornerRadius = 6F;
            this.txtSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondName.FastText = "";
            this.txtSecondName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSecondName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtSecondName.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSecondName.FontSize = 10.5F;
            this.txtSecondName.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSecondName.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtSecondName.InputType = FastUI.FastUILibrary.Core.FastInputType.LettersOnly;
            this.txtSecondName.Location = new System.Drawing.Point(1065, 127);
            this.txtSecondName.MoveTextHorizontal = 6;
            this.txtSecondName.MoveTextVertical = 0;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Placeholder = "Second Name";
            this.txtSecondName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtSecondName.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtSecondName.Size = new System.Drawing.Size(337, 34);
            this.txtSecondName.TabIndex = 58;
            this.txtSecondName.Text = "fuiTextBox1";
            this.txtSecondName.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtSecondName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSecondName.Theme = "Windows11";
            // 
            // txtThirdName
            // 
            this.txtThirdName.AllowSpace = true;
            this.txtThirdName.BackColor = System.Drawing.Color.Transparent;
            this.txtThirdName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtThirdName.BorderWidth = 1.2F;
            this.txtThirdName.CornerRadius = 6F;
            this.txtThirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThirdName.FastText = "";
            this.txtThirdName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtThirdName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtThirdName.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtThirdName.FontSize = 10.5F;
            this.txtThirdName.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtThirdName.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtThirdName.InputType = FastUI.FastUILibrary.Core.FastInputType.LettersOnly;
            this.txtThirdName.Location = new System.Drawing.Point(648, 218);
            this.txtThirdName.MoveTextHorizontal = 6;
            this.txtThirdName.MoveTextVertical = 0;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Placeholder = "Third Name";
            this.txtThirdName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtThirdName.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtThirdName.Size = new System.Drawing.Size(337, 34);
            this.txtThirdName.TabIndex = 59;
            this.txtThirdName.Text = "fuiTextBox2";
            this.txtThirdName.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtThirdName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtThirdName.Theme = "Windows11";
            // 
            // txtLastName
            // 
            this.txtLastName.AllowSpace = true;
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtLastName.BorderWidth = 1.2F;
            this.txtLastName.CornerRadius = 6F;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FastText = "";
            this.txtLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtLastName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtLastName.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLastName.FontSize = 10.5F;
            this.txtLastName.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtLastName.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtLastName.InputType = FastUI.FastUILibrary.Core.FastInputType.LettersOnly;
            this.txtLastName.Location = new System.Drawing.Point(1065, 218);
            this.txtLastName.MoveTextHorizontal = 6;
            this.txtLastName.MoveTextVertical = 0;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Placeholder = "Last Name";
            this.txtLastName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtLastName.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtLastName.Size = new System.Drawing.Size(337, 34);
            this.txtLastName.TabIndex = 60;
            this.txtLastName.Text = "fuiTextBox3";
            this.txtLastName.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtLastName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLastName.Theme = "Windows11";
            // 
            // txtNationalID
            // 
            this.txtNationalID.AllowSpace = true;
            this.txtNationalID.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNationalID.BorderWidth = 1.2F;
            this.txtNationalID.CornerRadius = 6F;
            this.txtNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalID.FastText = "";
            this.txtNationalID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtNationalID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtNationalID.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNationalID.FontSize = 10.5F;
            this.txtNationalID.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNationalID.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtNationalID.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
            this.txtNationalID.Location = new System.Drawing.Point(648, 305);
            this.txtNationalID.MoveTextHorizontal = 6;
            this.txtNationalID.MoveTextVertical = 0;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Placeholder = "National ID";
            this.txtNationalID.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtNationalID.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtNationalID.Size = new System.Drawing.Size(337, 34);
            this.txtNationalID.TabIndex = 61;
            this.txtNationalID.Text = "fuiTextBox4";
            this.txtNationalID.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtNationalID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNationalID.Theme = "Windows11";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEmail.BorderWidth = 1.2F;
            this.txtEmail.CornerRadius = 6F;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FastText = "";
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtEmail.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtEmail.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.FontSize = 10.5F;
            this.txtEmail.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtEmail.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtEmail.Location = new System.Drawing.Point(648, 412);
            this.txtEmail.MoveTextHorizontal = 6;
            this.txtEmail.MoveTextVertical = 0;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = "example@mail.com";
            this.txtEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtEmail.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtEmail.Required = false;
            this.txtEmail.Size = new System.Drawing.Size(336, 35);
            this.txtEmail.TabIndex = 65;
            this.txtEmail.Text = "fuiEmail1";
            this.txtEmail.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEmail.Theme = "Windows11";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPhone.BorderWidth = 1.2F;
            this.txtPhone.CornerRadius = 6F;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FastText = "";
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPhone.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtPhone.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPhone.FontSize = 10.5F;
            this.txtPhone.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPhone.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtPhone.Location = new System.Drawing.Point(1065, 412);
            this.txtPhone.MoveTextHorizontal = 6;
            this.txtPhone.MoveTextVertical = 0;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Placeholder = "+094";
            this.txtPhone.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtPhone.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtPhone.Required = false;
            this.txtPhone.Size = new System.Drawing.Size(329, 35);
            this.txtPhone.TabIndex = 66;
            this.txtPhone.Text = "fuiPhoneDz1";
            this.txtPhone.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtPhone.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPhone.Theme = "Windows11";
            // 
            // txtAddress
            // 
            this.txtAddress.AllowSpace = true;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddress.BorderWidth = 1.2F;
            this.txtAddress.CornerRadius = 6F;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FastText = "";
            this.txtAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAddress.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAddress.FontSize = 10.5F;
            this.txtAddress.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtAddress.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtAddress.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtAddress.Location = new System.Drawing.Point(649, 508);
            this.txtAddress.MoveTextHorizontal = 6;
            this.txtAddress.MoveTextVertical = 0;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Placeholder = "Address";
            this.txtAddress.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAddress.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAddress.Size = new System.Drawing.Size(336, 34);
            this.txtAddress.TabIndex = 67;
            this.txtAddress.Text = "fuiTextBox1";
            this.txtAddress.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtAddress.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAddress.Theme = "Windows11";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Transparent;
            this.btnADD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnADD.BorderWidth = 1.2F;
            this.btnADD.ControlHeight = 55;
            this.btnADD.ControlWidth = 133;
            this.btnADD.CornerRadius = 8F;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnADD.FontColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnADD.FontSize = 10.5F;
            this.btnADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnADD.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnADD.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnADD.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnADD.Location = new System.Drawing.Point(953, 601);
            this.btnADD.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnADD.MoveTextHorizontal = 0;
            this.btnADD.MoveTextVertical = 0;
            this.btnADD.Name = "btnADD";
            this.btnADD.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnADD.PressDepth = 2;
            this.btnADD.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnADD.Size = new System.Drawing.Size(133, 55);
            this.btnADD.TabIndex = 68;
            this.btnADD.Text = "ADD";
            this.btnADD.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnADD.Theme = "Windows11";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_2);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1493, 783);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCustomer";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtbDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FastUI.FastUILibrary.Components.FuiComboBox cbGender;
        private FastUI.FastUILibrary.Components.FuiTextBox txtNationalID;
        private FastUI.FastUILibrary.Components.FuiTextBox txtLastName;
        private FastUI.FastUILibrary.Components.FuiTextBox txtThirdName;
        private FastUI.FastUILibrary.Components.FuiTextBox txtSecondName;
        private FastUI.FastUILibrary.Components.FuiTextBox txtFirstName;
        private FastUI.FastUILibrary.Components.FuiEmail txtEmail;
        private FastUI.FastUILibrary.Components.FuiButton btnADD;
        private FastUI.FastUILibrary.Components.FuiTextBox txtAddress;
        private FastUI.FastUILibrary.Components.FuiPhoneDz txtPhone;
    }
}