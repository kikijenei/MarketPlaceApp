namespace Proiect2
{
    partial class Istoric
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
            this.istoricGridView = new System.Windows.Forms.DataGridView();
            this.istoricBtn = new System.Windows.Forms.Button();
            this.istoricLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.istoricGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // istoricGridView
            // 
            this.istoricGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.istoricGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.istoricGridView.Location = new System.Drawing.Point(39, 66);
            this.istoricGridView.Name = "istoricGridView";
            this.istoricGridView.RowHeadersWidth = 51;
            this.istoricGridView.RowTemplate.Height = 24;
            this.istoricGridView.Size = new System.Drawing.Size(438, 228);
            this.istoricGridView.TabIndex = 0;
            // 
            // istoricBtn
            // 
            this.istoricBtn.BackColor = System.Drawing.Color.Wheat;
            this.istoricBtn.Location = new System.Drawing.Point(187, 28);
            this.istoricBtn.Name = "istoricBtn";
            this.istoricBtn.Size = new System.Drawing.Size(36, 23);
            this.istoricBtn.TabIndex = 1;
            this.istoricBtn.UseVisualStyleBackColor = false;
            this.istoricBtn.Click += new System.EventHandler(this.istoricBtn_Click);
            // 
            // istoricLbl
            // 
            this.istoricLbl.AutoSize = true;
            this.istoricLbl.Location = new System.Drawing.Point(48, 31);
            this.istoricLbl.Name = "istoricLbl";
            this.istoricLbl.Size = new System.Drawing.Size(133, 16);
            this.istoricLbl.TabIndex = 2;
            this.istoricLbl.Text = "Afisare istoric vanzari";
            // 
            // Istoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(530, 339);
            this.Controls.Add(this.istoricLbl);
            this.Controls.Add(this.istoricBtn);
            this.Controls.Add(this.istoricGridView);
            this.Name = "Istoric";
            this.Text = "Istoric";
            ((System.ComponentModel.ISupportInitialize)(this.istoricGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView istoricGridView;
        private System.Windows.Forms.Button istoricBtn;
        private System.Windows.Forms.Label istoricLbl;
    }
}