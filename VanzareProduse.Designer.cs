namespace Proiect2
{
    partial class VanzareProduse
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
            this.denumireLbl = new System.Windows.Forms.Label();
            this.cantitatedispLbl = new System.Windows.Forms.Label();
            this.cantitatevandutLbl = new System.Windows.Forms.Label();
            this.numCantVandut = new System.Windows.Forms.NumericUpDown();
            this.vindeBtn = new System.Windows.Forms.Button();
            this.denumireCBox = new System.Windows.Forms.ComboBox();
            this.VanzarecantitatedispLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantVandut)).BeginInit();
            this.SuspendLayout();
            // 
            // denumireLbl
            // 
            this.denumireLbl.AutoSize = true;
            this.denumireLbl.Location = new System.Drawing.Point(57, 84);
            this.denumireLbl.Name = "denumireLbl";
            this.denumireLbl.Size = new System.Drawing.Size(68, 16);
            this.denumireLbl.TabIndex = 0;
            this.denumireLbl.Text = "Denumire:";
            // 
            // cantitatedispLbl
            // 
            this.cantitatedispLbl.AutoSize = true;
            this.cantitatedispLbl.Location = new System.Drawing.Point(199, 160);
            this.cantitatedispLbl.Name = "cantitatedispLbl";
            this.cantitatedispLbl.Size = new System.Drawing.Size(11, 16);
            this.cantitatedispLbl.TabIndex = 1;
            this.cantitatedispLbl.Text = "-";
            // 
            // cantitatevandutLbl
            // 
            this.cantitatevandutLbl.AutoSize = true;
            this.cantitatevandutLbl.Location = new System.Drawing.Point(57, 237);
            this.cantitatevandutLbl.Name = "cantitatevandutLbl";
            this.cantitatevandutLbl.Size = new System.Drawing.Size(124, 16);
            this.cantitatevandutLbl.TabIndex = 2;
            this.cantitatevandutLbl.Text = "Cantitate de vandut:";
            // 
            // numCantVandut
            // 
            this.numCantVandut.Location = new System.Drawing.Point(202, 235);
            this.numCantVandut.Name = "numCantVandut";
            this.numCantVandut.Size = new System.Drawing.Size(120, 22);
            this.numCantVandut.TabIndex = 4;
            // 
            // vindeBtn
            // 
            this.vindeBtn.BackColor = System.Drawing.Color.Wheat;
            this.vindeBtn.Location = new System.Drawing.Point(202, 321);
            this.vindeBtn.Name = "vindeBtn";
            this.vindeBtn.Size = new System.Drawing.Size(106, 44);
            this.vindeBtn.TabIndex = 7;
            this.vindeBtn.Text = "Vinde";
            this.vindeBtn.UseVisualStyleBackColor = false;
            this.vindeBtn.Click += new System.EventHandler(this.vindeBtn_Click);
            // 
            // denumireCBox
            // 
            this.denumireCBox.FormattingEnabled = true;
            this.denumireCBox.Location = new System.Drawing.Point(202, 81);
            this.denumireCBox.Name = "denumireCBox";
            this.denumireCBox.Size = new System.Drawing.Size(244, 24);
            this.denumireCBox.TabIndex = 8;
            this.denumireCBox.SelectedIndexChanged += new System.EventHandler(this.denumireCBox_SelectedIndexChanged);
            // 
            // VanzarecantitatedispLbl
            // 
            this.VanzarecantitatedispLbl.AutoSize = true;
            this.VanzarecantitatedispLbl.Location = new System.Drawing.Point(57, 160);
            this.VanzarecantitatedispLbl.Name = "VanzarecantitatedispLbl";
            this.VanzarecantitatedispLbl.Size = new System.Drawing.Size(128, 16);
            this.VanzarecantitatedispLbl.TabIndex = 9;
            this.VanzarecantitatedispLbl.Text = "Cantitate disponibila";
            // 
            // VanzareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(502, 411);
            this.Controls.Add(this.VanzarecantitatedispLbl);
            this.Controls.Add(this.denumireCBox);
            this.Controls.Add(this.vindeBtn);
            this.Controls.Add(this.numCantVandut);
            this.Controls.Add(this.cantitatevandutLbl);
            this.Controls.Add(this.cantitatedispLbl);
            this.Controls.Add(this.denumireLbl);
            this.Name = "VanzareProduse";
            this.Text = "VanzareProduse";
            ((System.ComponentModel.ISupportInitialize)(this.numCantVandut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label denumireLbl;
        private System.Windows.Forms.Label cantitatedispLbl;
        private System.Windows.Forms.Label cantitatevandutLbl;
        private System.Windows.Forms.NumericUpDown numCantVandut;
        private System.Windows.Forms.Button vindeBtn;
        private System.Windows.Forms.ComboBox denumireCBox;
        private System.Windows.Forms.Label VanzarecantitatedispLbl;
    }
}