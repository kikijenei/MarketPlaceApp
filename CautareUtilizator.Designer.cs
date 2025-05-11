namespace Proiect2
{
    partial class CautareUtilizator
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
            this.cautareUtilizatorTxt = new System.Windows.Forms.TextBox();
            this.cautareBtn = new System.Windows.Forms.Button();
            this.cautareUTILIZATORLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cautareUtilizatorTxt
            // 
            this.cautareUtilizatorTxt.Location = new System.Drawing.Point(160, 50);
            this.cautareUtilizatorTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cautareUtilizatorTxt.Name = "cautareUtilizatorTxt";
            this.cautareUtilizatorTxt.Size = new System.Drawing.Size(239, 22);
            this.cautareUtilizatorTxt.TabIndex = 5;
            this.cautareUtilizatorTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cautareUtilizatorTxt_KeyDown);
            // 
            // cautareBtn
            // 
            this.cautareBtn.BackColor = System.Drawing.Color.Wheat;
            this.cautareBtn.Location = new System.Drawing.Point(174, 96);
            this.cautareBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cautareBtn.Name = "cautareBtn";
            this.cautareBtn.Size = new System.Drawing.Size(96, 42);
            this.cautareBtn.TabIndex = 4;
            this.cautareBtn.Text = "Cauta";
            this.cautareBtn.UseVisualStyleBackColor = false;
            this.cautareBtn.Click += new System.EventHandler(this.cautareBtn_Click);
            // 
            // cautareUTILIZATORLbl
            // 
            this.cautareUTILIZATORLbl.AutoSize = true;
            this.cautareUTILIZATORLbl.Location = new System.Drawing.Point(26, 53);
            this.cautareUTILIZATORLbl.Name = "cautareUTILIZATORLbl";
            this.cautareUTILIZATORLbl.Size = new System.Drawing.Size(116, 16);
            this.cautareUTILIZATORLbl.TabIndex = 3;
            this.cautareUTILIZATORLbl.Text = "Utilizatorul cautat : ";
            // 
            // CautareUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(465, 174);
            this.Controls.Add(this.cautareUtilizatorTxt);
            this.Controls.Add(this.cautareBtn);
            this.Controls.Add(this.cautareUTILIZATORLbl);
            this.Name = "CautareUtilizator";
            this.Text = "CautareUtilizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cautareUtilizatorTxt;
        private System.Windows.Forms.Button cautareBtn;
        private System.Windows.Forms.Label cautareUTILIZATORLbl;
    }
}