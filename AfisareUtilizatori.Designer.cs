namespace Proiect2
{
    partial class AfisareUtilizatori
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
            this.utilizatoriLbl = new System.Windows.Forms.Label();
            this.utilizatoriBtn = new System.Windows.Forms.Button();
            this.utilizatoriGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // utilizatoriLbl
            // 
            this.utilizatoriLbl.AutoSize = true;
            this.utilizatoriLbl.Location = new System.Drawing.Point(33, 44);
            this.utilizatoriLbl.Name = "utilizatoriLbl";
            this.utilizatoriLbl.Size = new System.Drawing.Size(130, 16);
            this.utilizatoriLbl.TabIndex = 5;
            this.utilizatoriLbl.Text = "Afisare lista utilizatori";
            // 
            // utilizatoriBtn
            // 
            this.utilizatoriBtn.BackColor = System.Drawing.Color.Wheat;
            this.utilizatoriBtn.Location = new System.Drawing.Point(172, 41);
            this.utilizatoriBtn.Name = "utilizatoriBtn";
            this.utilizatoriBtn.Size = new System.Drawing.Size(36, 23);
            this.utilizatoriBtn.TabIndex = 4;
            this.utilizatoriBtn.UseVisualStyleBackColor = false;
            this.utilizatoriBtn.Click += new System.EventHandler(this.utilizatoriBtn_Click);
            // 
            // utilizatoriGridView
            // 
            this.utilizatoriGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.utilizatoriGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilizatoriGridView.Location = new System.Drawing.Point(36, 70);
            this.utilizatoriGridView.Name = "utilizatoriGridView";
            this.utilizatoriGridView.RowHeadersWidth = 51;
            this.utilizatoriGridView.RowTemplate.Height = 24;
            this.utilizatoriGridView.Size = new System.Drawing.Size(538, 312);
            this.utilizatoriGridView.TabIndex = 3;
            // 
            // AfisareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.utilizatoriLbl);
            this.Controls.Add(this.utilizatoriBtn);
            this.Controls.Add(this.utilizatoriGridView);
            this.Name = "AfisareUtilizatori";
            this.Text = "AfisareUtilizatori";
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label utilizatoriLbl;
        private System.Windows.Forms.Button utilizatoriBtn;
        private System.Windows.Forms.DataGridView utilizatoriGridView;
    }
}