namespace BankMangmentSystem.Transfer.Controls
{
    partial class ctrlCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelect = new FastUI.FastUILibrary.Components.FuiComboBox();
            this.btnSearch = new FastUI.FastUILibrary.Components.FuiButton();
            this.txtCustomerID = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtFullName = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtDateOfBith = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtNationalID = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtAccountID = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.AllowDrop = true;
            this.txtInput.AllowSpace = true;
            this.txtInput.BackColor = System.Drawing.Color.Transparent;
            this.txtInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtInput.BorderWidth = 1.2F;
            this.txtInput.CornerRadius = 6F;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.FastText = "";
            this.txtInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtInput.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtInput.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtInput.FontSize = 10.5F;
            this.txtInput.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtInput.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtInput.Location = new System.Drawing.Point(27, 103);
            this.txtInput.MoveTextHorizontal = 6;
            this.txtInput.MoveTextVertical = 0;
            this.txtInput.Name = "txtInput";
            this.txtInput.Placeholder = "Enter text...";
            this.txtInput.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtInput.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtInput.Size = new System.Drawing.Size(273, 52);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "fuiTextBox1";
            this.txtInput.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtInput.Theme = "Windows11";
            this.txtInput.Click += new System.EventHandler(this.txtInput_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(313, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelect
            // 
            this.cbSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbSelect.BorderWidth = 1.2F;
            this.cbSelect.CornerRadius = 6F;
            this.cbSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbSelect.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbSelect.FocusFillColor = System.Drawing.Color.White;
            this.cbSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSelect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbSelect.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbSelect.Items = new string[] {
        "CustomerID",
        "FullName",
        "NationalID",
        "AccountID"};
            this.cbSelect.Location = new System.Drawing.Point(341, 103);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Placeholder = "Select";
            this.cbSelect.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cbSelect.Size = new System.Drawing.Size(302, 49);
            this.cbSelect.TabIndex = 2;
            this.cbSelect.Text = "fuiComboBox1";
            this.cbSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbSelect.Theme = "Windows11";
            this.cbSelect.Click += new System.EventHandler(this.cbSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSearch.BorderWidth = 1.2F;
            this.btnSearch.ControlHeight = 36;
            this.btnSearch.ControlWidth = 125;
            this.btnSearch.CornerRadius = 8F;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnSearch.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.FontSize = 10.5F;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnSearch.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSearch.Location = new System.Drawing.Point(695, 103);
            this.btnSearch.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnSearch.MoveTextHorizontal = 0;
            this.btnSearch.MoveTextVertical = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnSearch.PressDepth = 2;
            this.btnSearch.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSearch.Size = new System.Drawing.Size(125, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnSearch.Theme = "Windows11";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.AllowSpace = true;
            this.txtCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCustomerID.BorderWidth = 1.2F;
            this.txtCustomerID.CornerRadius = 6F;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.FastText = "";
            this.txtCustomerID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtCustomerID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCustomerID.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCustomerID.FontSize = 10.5F;
            this.txtCustomerID.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtCustomerID.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtCustomerID.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtCustomerID.Location = new System.Drawing.Point(27, 224);
            this.txtCustomerID.MoveTextHorizontal = 6;
            this.txtCustomerID.MoveTextVertical = 0;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Placeholder = "CustomerID";
            this.txtCustomerID.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCustomerID.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCustomerID.Size = new System.Drawing.Size(355, 58);
            this.txtCustomerID.TabIndex = 4;
            this.txtCustomerID.Text = "Customer ID :";
            this.txtCustomerID.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtCustomerID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCustomerID.Theme = "Windows11";
            // 
            // txtFullName
            // 
            this.txtFullName.AllowSpace = true;
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtFullName.BorderWidth = 1.2F;
            this.txtFullName.CornerRadius = 6F;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Enabled = false;
            this.txtFullName.FastText = "";
            this.txtFullName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFullName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFullName.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFullName.FontSize = 10.5F;
            this.txtFullName.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFullName.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtFullName.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtFullName.Location = new System.Drawing.Point(560, 224);
            this.txtFullName.MoveTextHorizontal = 6;
            this.txtFullName.MoveTextVertical = 0;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Placeholder = "Full Name";
            this.txtFullName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFullName.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFullName.Size = new System.Drawing.Size(362, 58);
            this.txtFullName.TabIndex = 5;
            this.txtFullName.Text = "Full Name : ";
            this.txtFullName.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtFullName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFullName.Theme = "Windows11";
            // 
            // txtDateOfBith
            // 
            this.txtDateOfBith.AllowSpace = true;
            this.txtDateOfBith.BackColor = System.Drawing.Color.Transparent;
            this.txtDateOfBith.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDateOfBith.BorderWidth = 1.2F;
            this.txtDateOfBith.CornerRadius = 6F;
            this.txtDateOfBith.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateOfBith.Enabled = false;
            this.txtDateOfBith.FastText = "";
            this.txtDateOfBith.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtDateOfBith.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtDateOfBith.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDateOfBith.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDateOfBith.FontSize = 10.5F;
            this.txtDateOfBith.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtDateOfBith.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtDateOfBith.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtDateOfBith.Location = new System.Drawing.Point(27, 365);
            this.txtDateOfBith.MoveTextHorizontal = 6;
            this.txtDateOfBith.MoveTextVertical = 0;
            this.txtDateOfBith.Name = "txtDateOfBith";
            this.txtDateOfBith.Placeholder = "Date Of Birth";
            this.txtDateOfBith.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtDateOfBith.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtDateOfBith.Size = new System.Drawing.Size(355, 58);
            this.txtDateOfBith.TabIndex = 6;
            this.txtDateOfBith.Text = "Date Of Birth : ";
            this.txtDateOfBith.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtDateOfBith.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDateOfBith.Theme = "Windows11";
            // 
            // txtNationalID
            // 
            this.txtNationalID.AllowSpace = true;
            this.txtNationalID.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNationalID.BorderWidth = 1.2F;
            this.txtNationalID.CornerRadius = 6F;
            this.txtNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalID.Enabled = false;
            this.txtNationalID.FastText = "";
            this.txtNationalID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtNationalID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtNationalID.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNationalID.FontSize = 10.5F;
            this.txtNationalID.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNationalID.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtNationalID.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtNationalID.Location = new System.Drawing.Point(560, 365);
            this.txtNationalID.MoveTextHorizontal = 6;
            this.txtNationalID.MoveTextVertical = 0;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Placeholder = "NationalID";
            this.txtNationalID.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtNationalID.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtNationalID.Size = new System.Drawing.Size(362, 58);
            this.txtNationalID.TabIndex = 7;
            this.txtNationalID.Text = "CustomerID";
            this.txtNationalID.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtNationalID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNationalID.Theme = "Windows11";
            // 
            // txtAccountID
            // 
            this.txtAccountID.AllowSpace = true;
            this.txtAccountID.BackColor = System.Drawing.Color.Transparent;
            this.txtAccountID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAccountID.BorderWidth = 1.2F;
            this.txtAccountID.CornerRadius = 6F;
            this.txtAccountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountID.Enabled = false;
            this.txtAccountID.FastText = "";
            this.txtAccountID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtAccountID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAccountID.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAccountID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAccountID.FontSize = 10.5F;
            this.txtAccountID.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtAccountID.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtAccountID.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtAccountID.Location = new System.Drawing.Point(305, 487);
            this.txtAccountID.MoveTextHorizontal = 6;
            this.txtAccountID.MoveTextVertical = 0;
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Placeholder = "Account ID";
            this.txtAccountID.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAccountID.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAccountID.Size = new System.Drawing.Size(325, 58);
            this.txtAccountID.TabIndex = 8;
            this.txtAccountID.Text = "Account ID :";
            this.txtAccountID.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtAccountID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAccountID.Theme = "Windows11";
            // 
            // ctrlTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.txtNationalID);
            this.Controls.Add(this.txtDateOfBith);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "ctrlTransform";
            this.Size = new System.Drawing.Size(962, 577);
            this.Load += new System.EventHandler(this.ctrlTransform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FastUI.FastUILibrary.Components.FuiTextBox txtInput;
        private System.Windows.Forms.Label label1;
        private FastUI.FastUILibrary.Components.FuiComboBox cbSelect;
        private FastUI.FastUILibrary.Components.FuiButton btnSearch;
        private FastUI.FastUILibrary.Components.FuiTextBox txtCustomerID;
        private FastUI.FastUILibrary.Components.FuiTextBox txtFullName;
        private FastUI.FastUILibrary.Components.FuiTextBox txtDateOfBith;
        private FastUI.FastUILibrary.Components.FuiTextBox txtNationalID;
        private FastUI.FastUILibrary.Components.FuiTextBox txtAccountID;
    }
}