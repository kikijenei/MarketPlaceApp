namespace Proiect2
{
    partial class Cumparare
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
            this.cantitateCumparareLbl = new System.Windows.Forms.Label();
            this.denumireCBox = new System.Windows.Forms.ComboBox();
            this.cumparaBtn = new System.Windows.Forms.Button();
            this.numCantCumparat = new System.Windows.Forms.NumericUpDown();
            this.cantitatecumparatLbl = new System.Windows.Forms.Label();
            this.cantitatedispLbl = new System.Windows.Forms.Label();
            this.CumpararedenumireLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCumparat)).BeginInit();
            this.SuspendLayout();
            // 
            // cantitateCumparareLbl
            // 
            this.cantitateCumparareLbl.AutoSize = true;
            this.cantitateCumparareLbl.Location = new System.Drawing.Point(39, 152);
            this.cantitateCumparareLbl.Name = "cantitateCumparareLbl";
            this.cantitateCumparareLbl.Size = new System.Drawing.Size(128, 16);
            this.cantitateCumparareLbl.TabIndex = 16;
            this.cantitateCumparareLbl.Text = "Cantitate disponibila";
            // 
            // denumireCBox
            // 
            this.denumireCBox.FormattingEnabled = true;
            this.denumireCBox.Location = new System.Drawing.Point(184, 73);
            this.denumireCBox.Name = "denumireCBox";
            this.denumireCBox.Size = new System.Drawing.Size(244, 24);
            this.denumireCBox.TabIndex = 15;
            this.denumireCBox.SelectedIndexChanged += new System.EventHandler(this.denumireCBox_SelectedIndexChanged);
            // 
            // cumparaBtn
            // 
            this.cumparaBtn.BackColor = System.Drawing.Color.Wheat;
            this.cumparaBtn.Location = new System.Drawing.Point(184, 313);
            this.cumparaBtn.Name = "cumparaBtn";
            this.cumparaBtn.Size = new System.Drawing.Size(106, 44);
            this.cumparaBtn.TabIndex = 14;
            this.cumparaBtn.Text = "Cumpara";
            this.cumparaBtn.UseVisualStyleBackColor = false;
            this.cumparaBtn.Click += new System.EventHandler(this.cumparaBtn_Click);
            // 
            // numCantCumparat
            // 
            this.numCantCumparat.Location = new System.Drawing.Point(184, 227);
            this.numCantCumparat.Name = "numCantCumparat";
            this.numCantCumparat.Size = new System.Drawing.Size(120, 22);
            this.numCantCumparat.TabIndex = 13;
            // 
            // cantitatecumparatLbl
            // 
            this.cantitatecumparatLbl.AutoSize = true;
            this.cantitatecumparatLbl.Location = new System.Drawing.Point(39, 229);
            this.cantitatecumparatLbl.Name = "cantitatecumparatLbl";
            this.cantitatecumparatLbl.Size = new System.Drawing.Size(137, 16);
            this.cantitatecumparatLbl.TabIndex = 12;
            this.cantitatecumparatLbl.Text = "Cantitate de cumparat";
            // 
            // cantitatedispLbl
            // 
            this.cantitatedispLbl.AutoSize = true;
            this.cantitatedispLbl.Location = new System.Drawing.Point(181, 152);
            this.cantitatedispLbl.Name = "cantitatedispLbl";
            this.cantitatedispLbl.Size = new System.Drawing.Size(11, 16);
            this.cantitatedispLbl.TabIndex = 11;
            this.cantitatedispLbl.Text = "-";
            // 
            // CumpararedenumireLbl
            // 
            this.CumpararedenumireLbl.AutoSize = true;
            this.CumpararedenumireLbl.Location = new System.Drawing.Point(39, 76);
            this.CumpararedenumireLbl.Name = "CumpararedenumireLbl";
            this.CumpararedenumireLbl.Size = new System.Drawing.Size(68, 16);
            this.CumpararedenumireLbl.TabIndex = 10;
            this.CumpararedenumireLbl.Text = "Denumire:";
            // 
            // Cumparare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(457, 431);
            this.Controls.Add(this.cantitateCumparareLbl);
            this.Controls.Add(this.denumireCBox);
            this.Controls.Add(this.cumparaBtn);
            this.Controls.Add(this.numCantCumparat);
            this.Controls.Add(this.cantitatecumparatLbl);
            this.Controls.Add(this.cantitatedispLbl);
            this.Controls.Add(this.CumpararedenumireLbl);
            this.Name = "Cumparare";
            this.Text = "Cumparare";
            ((System.ComponentModel.ISupportInitialize)(this.numCantCumparat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cantitateCumparareLbl;
        private System.Windows.Forms.ComboBox denumireCBox;
        private System.Windows.Forms.Button cumparaBtn;
        private System.Windows.Forms.NumericUpDown numCantCumparat;
        private System.Windows.Forms.Label cantitatecumparatLbl;
        private System.Windows.Forms.Label cantitatedispLbl;
        private System.Windows.Forms.Label CumpararedenumireLbl;
    }
}