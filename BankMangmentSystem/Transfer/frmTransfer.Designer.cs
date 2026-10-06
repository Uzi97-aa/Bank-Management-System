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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransfer = new FastUI.FastUILibrary.Components.FuiButton();
            this.ctrlUserWithFilter2 = new BankMangmentSystem.User.Controls.ctrlUserWithFilter();
            this.ctrlUserWithFilter1 = new BankMangmentSystem.User.Controls.ctrlUserWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "User 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1328, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "User 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransfer
            // 
            this.btnTransfer.AllowDrop = true;
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnTransfer.BorderWidth = 1.2F;
            this.btnTransfer.ControlHeight = 36;
            this.btnTransfer.ControlWidth = 125;
            this.btnTransfer.CornerRadius = 8F;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTransfer.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTransfer.FontSize = 10.5F;
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTransfer.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnTransfer.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnTransfer.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnTransfer.Location = new System.Drawing.Point(862, 528);
            this.btnTransfer.MoreFontSettings = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTransfer.MoveTextHorizontal = 0;
            this.btnTransfer.MoveTextVertical = 0;
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnTransfer.PressDepth = 2;
            this.btnTransfer.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnTransfer.Size = new System.Drawing.Size(125, 36);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Tranfer";
            this.btnTransfer.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            this.btnTransfer.Theme = "Windows11";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // ctrlUserWithFilter2
            // 
            this.ctrlUserWithFilter2.BackColor = System.Drawing.Color.DodgerBlue;
            this.ctrlUserWithFilter2.Location = new System.Drawing.Point(982, 80);
            this.ctrlUserWithFilter2.Name = "ctrlUserWithFilter2";
            this.ctrlUserWithFilter2.Size = new System.Drawing.Size(878, 396);
            this.ctrlUserWithFilter2.TabIndex = 1;
            // 
            // ctrlUserWithFilter1
            // 
            this.ctrlUserWithFilter1.BackColor = System.Drawing.Color.DodgerBlue;
            this.ctrlUserWithFilter1.Location = new System.Drawing.Point(12, 80);
            this.ctrlUserWithFilter1.Name = "ctrlUserWithFilter1";
            this.ctrlUserWithFilter1.Size = new System.Drawing.Size(878, 396);
            this.ctrlUserWithFilter1.TabIndex = 0;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1924, 589);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlUserWithFilter2);
            this.Controls.Add(this.ctrlUserWithFilter1);
            this.Name = "frmTransfer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User.Controls.ctrlUserWithFilter ctrlUserWithFilter1;
        private User.Controls.ctrlUserWithFilter ctrlUserWithFilter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FastUI.FastUILibrary.Components.FuiButton btnTransfer;
    }
}