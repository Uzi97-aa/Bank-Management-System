namespace BankMangmentSystem.User
{
    partial class frmListUses
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
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSelect = new FastUI.FastUILibrary.Components.FuiComboBox();
            this.txtFilterValue = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.btnAddUser = new FastUI.FastUILibrary.Components.FuiButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserList.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.GridColor = System.Drawing.Color.Black;
            this.dgvUserList.Location = new System.Drawing.Point(-2, 61);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.RowTemplate.Height = 24;
            this.dgvUserList.Size = new System.Drawing.Size(1424, 526);
            this.dgvUserList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecord.Location = new System.Drawing.Point(102, 609);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(61, 27);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "??";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter By :";
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
        "UserID",
        "CustomerID",
        "EmployeeID",
        "UserName",
        "Role",
        "FullName"};
            this.cbSelect.Location = new System.Drawing.Point(119, 24);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Placeholder = "Select";
            this.cbSelect.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cbSelect.Size = new System.Drawing.Size(202, 31);
            this.cbSelect.TabIndex = 4;
            this.cbSelect.Text = "fuiComboBox1";
            this.cbSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbSelect.Theme = "Windows11";
            this.cbSelect.Click += new System.EventHandler(this.fuiComboBox1_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AllowSpace = true;
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtFilterValue.BorderWidth = 1.2F;
            this.txtFilterValue.CornerRadius = 6F;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FastText = "";
            this.txtFilterValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFilterValue.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFilterValue.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFilterValue.FontSize = 10.5F;
            this.txtFilterValue.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFilterValue.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtFilterValue.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.txtFilterValue.Location = new System.Drawing.Point(343, 24);
            this.txtFilterValue.MoveTextHorizontal = 6;
            this.txtFilterValue.MoveTextVertical = 0;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Placeholder = "Enter text...";
            this.txtFilterValue.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFilterValue.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtFilterValue.Size = new System.Drawing.Size(215, 31);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.Text = "fuiTextBox1";
            this.txtFilterValue.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.txtFilterValue.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFilterValue.Theme = "Windows11";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.Click += new System.EventHandler(this.txtFilterValue_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAddUser.BorderWidth = 1.2F;
            this.btnAddUser.ControlHeight = 36;
            this.btnAddUser.ControlWidth = 125;
            this.btnAddUser.CornerRadius = 8F;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnAddUser.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddUser.FontSize = 10.5F;
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddUser.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddUser.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAddUser.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAddUser.Location = new System.Drawing.Point(1217, 12);
            this.btnAddUser.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnAddUser.MoveTextHorizontal = 0;
            this.btnAddUser.MoveTextVertical = 0;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnAddUser.PressDepth = 2;
            this.btnAddUser.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnAddUser.Size = new System.Drawing.Size(125, 36);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnAddUser.Theme = "Windows11";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(613, 24);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(228, 31);
            this.txtValue.TabIndex = 7;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // frmListUses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1424, 645);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUserList);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListUses";
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.frmListUses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label3;
        private FastUI.FastUILibrary.Components.FuiComboBox cbSelect;
        private FastUI.FastUILibrary.Components.FuiTextBox txtFilterValue;
        private FastUI.FastUILibrary.Components.FuiButton btnAddUser;
        private System.Windows.Forms.TextBox txtValue;
    }
}