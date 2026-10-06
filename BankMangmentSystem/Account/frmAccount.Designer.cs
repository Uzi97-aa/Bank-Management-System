using System.Threading.Tasks;

namespace BankMangmentSystem
{
    partial class frmAccount
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnSave = new FastUI.FastUILibrary.Components.FuiButton();
            this.txtCustomerID = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtBranchID = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtAccountNumber = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.txtCurrencyID = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.cbAccountStatus = new FastUI.FastUILibrary.Components.FuiComboBox();
            this.fuiButton2 = new FastUI.FastUILibrary.Components.FuiButton();
            this.cbStatus = new FastUI.FastUILibrary.Components.FuiComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(991, 492);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(446, 55);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(191, 36);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "ADD NEW";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSave.BorderWidth = 1.2F;
            this.btnSave.ControlHeight = 36;
            this.btnSave.ControlWidth = 125;
            this.btnSave.CornerRadius = 8F;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnSave.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.FontSize = 10.5F;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnSave.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSave.Location = new System.Drawing.Point(483, 410);
            this.btnSave.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnSave.MoveTextHorizontal = 0;
            this.btnSave.MoveTextVertical = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnSave.PressDepth = 2;
            this.btnSave.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnSave.Theme = "Windows11";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.AllowSpace = true;
            this.txtCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCustomerID.BorderWidth = 1.2F;
            this.txtCustomerID.CornerRadius = 6F;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.FastText = "";
            this.txtCustomerID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtCustomerID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCustomerID.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCustomerID.FontSize = 10.5F;
            this.txtCustomerID.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtCustomerID.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtCustomerID.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
            this.txtCustomerID.Location = new System.Drawing.Point(118, 132);
            this.txtCustomerID.MoveTextHorizontal = 6;
            this.txtCustomerID.MoveTextVertical = 0;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Placeholder = "Customer ID";
            this.txtCustomerID.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCustomerID.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCustomerID.Size = new System.Drawing.Size(225, 46);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.Text = "fuiTextBox1";
            this.txtCustomerID.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtCustomerID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCustomerID.Theme = "Windows11";
            // 
            // txtBranchID
            // 
            this.txtBranchID.AllowSpace = true;
            this.txtBranchID.BackColor = System.Drawing.Color.Transparent;
            this.txtBranchID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtBranchID.BorderWidth = 1.2F;
            this.txtBranchID.CornerRadius = 6F;
            this.txtBranchID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBranchID.FastText = "";
            this.txtBranchID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtBranchID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtBranchID.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBranchID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBranchID.FontSize = 10.5F;
            this.txtBranchID.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtBranchID.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtBranchID.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
            this.txtBranchID.Location = new System.Drawing.Point(740, 132);
            this.txtBranchID.MoveTextHorizontal = 6;
            this.txtBranchID.MoveTextVertical = 0;
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Placeholder = "Branch ID";
            this.txtBranchID.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtBranchID.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtBranchID.Size = new System.Drawing.Size(229, 46);
            this.txtBranchID.TabIndex = 4;
            this.txtBranchID.Text = "fuiTextBox2";
            this.txtBranchID.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtBranchID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBranchID.Theme = "Windows11";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.AllowSpace = true;
            this.txtAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtAccountNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAccountNumber.BorderWidth = 1.2F;
            this.txtAccountNumber.CornerRadius = 6F;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.FastText = "";
            this.txtAccountNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtAccountNumber.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAccountNumber.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAccountNumber.FontSize = 10.5F;
            this.txtAccountNumber.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtAccountNumber.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtAccountNumber.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtAccountNumber.Location = new System.Drawing.Point(118, 230);
            this.txtAccountNumber.MoveTextHorizontal = 6;
            this.txtAccountNumber.MoveTextVertical = 0;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Placeholder = "Account Number";
            this.txtAccountNumber.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAccountNumber.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtAccountNumber.Size = new System.Drawing.Size(225, 47);
            this.txtAccountNumber.TabIndex = 5;
            this.txtAccountNumber.Text = "fuiTextBox3";
            this.txtAccountNumber.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtAccountNumber.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAccountNumber.Theme = "Windows11";
            // 
            // txtCurrencyID
            // 
            this.txtCurrencyID.AllowSpace = true;
            this.txtCurrencyID.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrencyID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCurrencyID.BorderWidth = 1.2F;
            this.txtCurrencyID.CornerRadius = 6F;
            this.txtCurrencyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrencyID.FastText = "";
            this.txtCurrencyID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtCurrencyID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCurrencyID.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCurrencyID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCurrencyID.FontSize = 10.5F;
            this.txtCurrencyID.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtCurrencyID.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtCurrencyID.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
            this.txtCurrencyID.Location = new System.Drawing.Point(118, 324);
            this.txtCurrencyID.MoveTextHorizontal = 6;
            this.txtCurrencyID.MoveTextVertical = 0;
            this.txtCurrencyID.Name = "txtCurrencyID";
            this.txtCurrencyID.Placeholder = "Currency ID";
            this.txtCurrencyID.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCurrencyID.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtCurrencyID.Size = new System.Drawing.Size(225, 46);
            this.txtCurrencyID.TabIndex = 7;
            this.txtCurrencyID.Text = "fuiTextBox5";
            this.txtCurrencyID.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtCurrencyID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCurrencyID.Theme = "Windows11";
            // 
            // cbAccountStatus
            // 
            this.cbAccountStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbAccountStatus.BorderWidth = 1.2F;
            this.cbAccountStatus.CornerRadius = 6F;
            this.cbAccountStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAccountStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbAccountStatus.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbAccountStatus.FocusFillColor = System.Drawing.Color.White;
            this.cbAccountStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAccountStatus.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbAccountStatus.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbAccountStatus.Items = new string[] {
        "Savings",
        "Current",
        "Fixed"};
            this.cbAccountStatus.Location = new System.Drawing.Point(740, 230);
            this.cbAccountStatus.Name = "cbAccountStatus";
            this.cbAccountStatus.Placeholder = "Select";
            this.cbAccountStatus.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cbAccountStatus.Size = new System.Drawing.Size(229, 47);
            this.cbAccountStatus.TabIndex = 9;
            this.cbAccountStatus.Text = "fuiComboBox1";
            this.cbAccountStatus.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbAccountStatus.Theme = "Windows11";
            // 
            // fuiButton2
            // 
            this.fuiButton2.BackColor = System.Drawing.Color.Transparent;
            this.fuiButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fuiButton2.BorderWidth = 1.2F;
            this.fuiButton2.ControlHeight = 36;
            this.fuiButton2.ControlWidth = 229;
            this.fuiButton2.CornerRadius = 8F;
            this.fuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fuiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fuiButton2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fuiButton2.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiButton2.FontSize = 10.5F;
            this.fuiButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiButton2.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fuiButton2.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.fuiButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.fuiButton2.Location = new System.Drawing.Point(740, 324);
            this.fuiButton2.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fuiButton2.MoveTextHorizontal = 0;
            this.fuiButton2.MoveTextVertical = 0;
            this.fuiButton2.Name = "fuiButton2";
            this.fuiButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.fuiButton2.PressDepth = 2;
            this.fuiButton2.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.fuiButton2.Size = new System.Drawing.Size(229, 36);
            this.fuiButton2.TabIndex = 10;
            this.fuiButton2.Text = "Show Currency List";
            this.fuiButton2.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.fuiButton2.Theme = "Windows11";
            this.fuiButton2.Click += new System.EventHandler(this.fuiButton2_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbStatus.BorderWidth = 1.2F;
            this.cbStatus.CornerRadius = 6F;
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbStatus.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbStatus.FocusFillColor = System.Drawing.Color.White;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbStatus.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbStatus.Items = new string[] {
        "Active",
        "Frozen",
        "Closed"};
            this.cbStatus.Location = new System.Drawing.Point(431, 231);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Placeholder = "Select";
            this.cbStatus.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cbStatus.Size = new System.Drawing.Size(233, 45);
            this.cbStatus.TabIndex = 11;
            this.cbStatus.Text = "fuiComboBox1";
            this.cbStatus.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbStatus.Theme = "Windows11";
            this.cbStatus.Visible = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1060, 539);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.fuiButton2);
            this.Controls.Add(this.cbAccountStatus);
            this.Controls.Add(this.txtCurrencyID);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtBranchID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblAccount;
        private FastUI.FastUILibrary.Components.FuiButton btnSave;
        private FastUI.FastUILibrary.Components.FuiTextBox txtCustomerID;
        private FastUI.FastUILibrary.Components.FuiTextBox txtBranchID;
        private FastUI.FastUILibrary.Components.FuiTextBox txtAccountNumber;
        private FastUI.FastUILibrary.Components.FuiTextBox txtCurrencyID;
        private FastUI.FastUILibrary.Components.FuiComboBox cbAccountStatus;
        private FastUI.FastUILibrary.Components.FuiButton fuiButton2;
        private FastUI.FastUILibrary.Components.FuiComboBox cbStatus;
    }
}