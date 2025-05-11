namespace Proiect2
{
    partial class StergereUtilizator
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
            this.utilizatorCBox = new System.Windows.Forms.ComboBox();
            this.stergereBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // utilizatorCBox
            // 
            this.utilizatorCBox.FormattingEnabled = true;
            this.utilizatorCBox.Location = new System.Drawing.Point(114, 51);
            this.utilizatorCBox.Name = "utilizatorCBox";
            this.utilizatorCBox.Size = new System.Drawing.Size(193, 24);
            this.utilizatorCBox.TabIndex = 5;
            this.utilizatorCBox.SelectedIndexChanged += new System.EventHandler(this.utilizatorCBox_SelectedIndexChanged);
            // 
            // stergereBtn
            // 
            this.stergereBtn.BackColor = System.Drawing.Color.Wheat;
            this.stergereBtn.Location = new System.Drawing.Point(160, 101);
            this.stergereBtn.Name = "stergereBtn";
            this.stergereBtn.Size = new System.Drawing.Size(94, 35);
            this.stergereBtn.TabIndex = 4;
            this.stergereBtn.Text = "Stergere";
            this.stergereBtn.UseVisualStyleBackColor = false;
            this.stergereBtn.Click += new System.EventHandler(this.stergereBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(34, 54);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(64, 16);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Utilizator: ";
            // 
            // StergereUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(414, 181);
            this.Controls.Add(this.utilizatorCBox);
            this.Controls.Add(this.stergereBtn);
            this.Controls.Add(this.usernameLbl);
            this.Name = "StergereUtilizator";
            this.Text = "StergereUtilizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox utilizatorCBox;
        private System.Windows.Forms.Button stergereBtn;
        private System.Windows.Forms.Label usernameLbl;
    }
}