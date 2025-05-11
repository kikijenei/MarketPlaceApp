namespace Proiect2
{
    partial class CautareProduse
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
            this.cautareProdLbl = new System.Windows.Forms.Label();
            this.cautareBtn = new System.Windows.Forms.Button();
            this.cautareTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cautareProdLbl
            // 
            this.cautareProdLbl.AutoSize = true;
            this.cautareProdLbl.Location = new System.Drawing.Point(12, 71);
            this.cautareProdLbl.Name = "cautareProdLbl";
            this.cautareProdLbl.Size = new System.Drawing.Size(186, 16);
            this.cautareProdLbl.TabIndex = 0;
            this.cautareProdLbl.Text = "Denumirea produsului cautat : ";
            // 
            // cautareBtn
            // 
            this.cautareBtn.BackColor = System.Drawing.Color.Wheat;
            this.cautareBtn.Location = new System.Drawing.Point(170, 109);
            this.cautareBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cautareBtn.Name = "cautareBtn";
            this.cautareBtn.Size = new System.Drawing.Size(96, 42);
            this.cautareBtn.TabIndex = 1;
            this.cautareBtn.Text = "Cauta";
            this.cautareBtn.UseVisualStyleBackColor = false;
            this.cautareBtn.Click += new System.EventHandler(this.cautareBtn_Click);
            // 
            // cautareTxt
            // 
            this.cautareTxt.Location = new System.Drawing.Point(204, 68);
            this.cautareTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cautareTxt.Name = "cautareTxt";
            this.cautareTxt.Size = new System.Drawing.Size(239, 22);
            this.cautareTxt.TabIndex = 2;
            this.cautareTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cautareTxt_KeyDown);
            // 
            // CautareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(465, 174);
            this.Controls.Add(this.cautareTxt);
            this.Controls.Add(this.cautareBtn);
            this.Controls.Add(this.cautareProdLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CautareProduse";
            this.Text = "CautareProduse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cautareProdLbl;
        private System.Windows.Forms.Button cautareBtn;
        private System.Windows.Forms.TextBox cautareTxt;
    }
}