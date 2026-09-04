namespace BankMangmentSystem.Transfer
{
    partial class frmTransfer
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
            this.lblCustomer1 = new System.Windows.Forms.Label();
            this.lblCustomer2 = new System.Windows.Forms.Label();
            this.fuiButton1 = new FastUI.FastUILibrary.Components.FuiButton();
            this.ctrlTransform2 = new BankMangmentSystem.Transfer.Controls.ctrlTransform();
            this.ctrlTransform1 = new BankMangmentSystem.Transfer.Controls.ctrlTransform();
            this.SuspendLayout();
            // 
            // lblCustomer1
            // 
            this.lblCustomer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCustomer1.Location = new System.Drawing.Point(284, 31);
            this.lblCustomer1.Name = "lblCustomer1";
            this.lblCustomer1.Size = new System.Drawing.Size(180, 43);
            this.lblCustomer1.TabIndex = 2;
            this.lblCustomer1.Text = "Customer 1";
            this.lblCustomer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer2
            // 
            this.lblCustomer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCustomer2.Location = new System.Drawing.Point(1246, 31);
            this.lblCustomer2.Name = "lblCustomer2";
            this.lblCustomer2.Size = new System.Drawing.Size(144, 43);
            this.lblCustomer2.TabIndex = 3;
            this.lblCustomer2.Text = "Customer 2";
            this.lblCustomer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuiButton1
            // 
            this.fuiButton1.BackColor = System.Drawing.Color.Transparent;
            this.fuiButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fuiButton1.BorderWidth = 1.2F;
            this.fuiButton1.ControlHeight = 36;
            this.fuiButton1.ControlWidth = 125;
            this.fuiButton1.CornerRadius = 8F;
            this.fuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fuiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fuiButton1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fuiButton1.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiButton1.FontSize = 10.5F;
            this.fuiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiButton1.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fuiButton1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.fuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.fuiButton1.Location = new System.Drawing.Point(836, 779);
            this.fuiButton1.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fuiButton1.MoveTextHorizontal = 0;
            this.fuiButton1.MoveTextVertical = 0;
            this.fuiButton1.Name = "fuiButton1";
            this.fuiButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.fuiButton1.PressDepth = 2;
            this.fuiButton1.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.fuiButton1.Size = new System.Drawing.Size(125, 36);
            this.fuiButton1.TabIndex = 4;
            this.fuiButton1.Text = "Transfer";
            this.fuiButton1.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.fuiButton1.Theme = "Windows11";
            this.fuiButton1.Click += new System.EventHandler(this.fuiButton1_Click);
            // 
            // ctrlTransform2
            // 
            this.ctrlTransform2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ctrlTransform2.Location = new System.Drawing.Point(959, 94);
            this.ctrlTransform2.Name = "ctrlTransform2";
            this.ctrlTransform2.Size = new System.Drawing.Size(962, 577);
            this.ctrlTransform2.TabIndex = 1;
            // 
            // ctrlTransform1
            // 
            this.ctrlTransform1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ctrlTransform1.Location = new System.Drawing.Point(-8, 94);
            this.ctrlTransform1.Name = "ctrlTransform1";
            this.ctrlTransform1.Size = new System.Drawing.Size(934, 577);
            this.ctrlTransform1.TabIndex = 0;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 898);
            this.Controls.Add(this.fuiButton1);
            this.Controls.Add(this.lblCustomer2);
            this.Controls.Add(this.lblCustomer1);
            this.Controls.Add(this.ctrlTransform2);
            this.Controls.Add(this.ctrlTransform1);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlTransform ctrlTransform1;
        private Controls.ctrlTransform ctrlTransform2;
        private System.Windows.Forms.Label lblCustomer1;
        private System.Windows.Forms.Label lblCustomer2;
        private FastUI.FastUILibrary.Components.FuiButton fuiButton1;
    }
}