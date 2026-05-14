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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fuiComboBox1 = new FastUI.FastUILibrary.Components.FuiComboBox();
            this.fuiTextBox1 = new FastUI.FastUILibrary.Components.FuiTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1418, 519);
            this.dataGridView1.TabIndex = 0;
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(102, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "??";
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
            // fuiComboBox1
            // 
            this.fuiComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fuiComboBox1.BorderWidth = 1.2F;
            this.fuiComboBox1.CornerRadius = 6F;
            this.fuiComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fuiComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fuiComboBox1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiComboBox1.FocusFillColor = System.Drawing.Color.White;
            this.fuiComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fuiComboBox1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fuiComboBox1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fuiComboBox1.Items = new string[0];
            this.fuiComboBox1.Location = new System.Drawing.Point(119, 24);
            this.fuiComboBox1.Name = "fuiComboBox1";
            this.fuiComboBox1.Placeholder = "Select";
            this.fuiComboBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.fuiComboBox1.Size = new System.Drawing.Size(202, 31);
            this.fuiComboBox1.TabIndex = 4;
            this.fuiComboBox1.Text = "fuiComboBox1";
            this.fuiComboBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiComboBox1.Theme = "Windows11";
            // 
            // fuiTextBox1
            // 
            this.fuiTextBox1.AllowSpace = true;
            this.fuiTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.fuiTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fuiTextBox1.BorderWidth = 1.2F;
            this.fuiTextBox1.CornerRadius = 6F;
            this.fuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fuiTextBox1.FastText = "";
            this.fuiTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fuiTextBox1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTextBox1.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fuiTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fuiTextBox1.FontSize = 10.5F;
            this.fuiTextBox1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fuiTextBox1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fuiTextBox1.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
            this.fuiTextBox1.Location = new System.Drawing.Point(343, 24);
            this.fuiTextBox1.MoveTextHorizontal = 6;
            this.fuiTextBox1.MoveTextVertical = 0;
            this.fuiTextBox1.Name = "fuiTextBox1";
            this.fuiTextBox1.Placeholder = "Enter text...";
            this.fuiTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTextBox1.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTextBox1.Size = new System.Drawing.Size(183, 31);
            this.fuiTextBox1.TabIndex = 5;
            this.fuiTextBox1.Text = "fuiTextBox1";
            this.fuiTextBox1.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.fuiTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiTextBox1.Theme = "Windows11";
            // 
            // frmListUses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 645);
            this.Controls.Add(this.fuiTextBox1);
            this.Controls.Add(this.fuiComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListUses";
            this.Text = "Users List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FastUI.FastUILibrary.Components.FuiComboBox fuiComboBox1;
        private FastUI.FastUILibrary.Components.FuiTextBox fuiTextBox1;
    }
}