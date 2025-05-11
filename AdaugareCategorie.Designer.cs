namespace Proiect2
{
    partial class AdaugareCategorie
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
            this.categorieBtn = new System.Windows.Forms.Button();
            this.categorieLbl = new System.Windows.Forms.Label();
            this.categorieTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categorieBtn
            // 
            this.categorieBtn.BackColor = System.Drawing.Color.Wheat;
            this.categorieBtn.Location = new System.Drawing.Point(166, 128);
            this.categorieBtn.Name = "categorieBtn";
            this.categorieBtn.Size = new System.Drawing.Size(101, 32);
            this.categorieBtn.TabIndex = 0;
            this.categorieBtn.Text = "Salveaza";
            this.categorieBtn.UseVisualStyleBackColor = false;
            this.categorieBtn.Click += new System.EventHandler(this.categorieBtn_Click);
            this.categorieBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categorieBtn_KeyDown);
            // 
            // categorieLbl
            // 
            this.categorieLbl.AutoSize = true;
            this.categorieLbl.Location = new System.Drawing.Point(37, 64);
            this.categorieLbl.Name = "categorieLbl";
            this.categorieLbl.Size = new System.Drawing.Size(105, 16);
            this.categorieLbl.TabIndex = 1;
            this.categorieLbl.Text = "Categorie noua: ";
            // 
            // categorieTxt
            // 
            this.categorieTxt.Location = new System.Drawing.Point(153, 61);
            this.categorieTxt.Name = "categorieTxt";
            this.categorieTxt.Size = new System.Drawing.Size(184, 22);
            this.categorieTxt.TabIndex = 2;
            // 
            // AdaugareCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(444, 203);
            this.Controls.Add(this.categorieTxt);
            this.Controls.Add(this.categorieLbl);
            this.Controls.Add(this.categorieBtn);
            this.Name = "AdaugareCategorie";
            this.Text = "AdaugareCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button categorieBtn;
        private System.Windows.Forms.Label categorieLbl;
        private System.Windows.Forms.TextBox categorieTxt;
    }
}