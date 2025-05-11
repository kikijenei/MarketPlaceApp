namespace Proiect2
{
    partial class ModificareParola
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
            this.signInGB = new System.Windows.Forms.GroupBox();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.txtParolaNoua = new System.Windows.Forms.TextBox();
            this.txtParolaVeche = new System.Windows.Forms.TextBox();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.lblParolaNoua = new System.Windows.Forms.Label();
            this.lblParolaVeche = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.signInGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInGB
            // 
            this.signInGB.Controls.Add(this.btnInapoi);
            this.signInGB.Controls.Add(this.btnSalvare);
            this.signInGB.Controls.Add(this.txtParolaNoua);
            this.signInGB.Controls.Add(this.txtParolaVeche);
            this.signInGB.Controls.Add(this.txtUtilizator);
            this.signInGB.Controls.Add(this.lblParolaNoua);
            this.signInGB.Controls.Add(this.lblParolaVeche);
            this.signInGB.Controls.Add(this.lblUtilizator);
            this.signInGB.Location = new System.Drawing.Point(24, 46);
            this.signInGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInGB.Name = "signInGB";
            this.signInGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInGB.Size = new System.Drawing.Size(382, 296);
            this.signInGB.TabIndex = 1;
            this.signInGB.TabStop = false;
            this.signInGB.Text = ".";
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Wheat;
            this.btnInapoi.Location = new System.Drawing.Point(77, 223);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(97, 36);
            this.btnInapoi.TabIndex = 9;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.Wheat;
            this.btnSalvare.Location = new System.Drawing.Point(217, 223);
            this.btnSalvare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(97, 36);
            this.btnSalvare.TabIndex = 8;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // txtParolaNoua
            // 
            this.txtParolaNoua.Location = new System.Drawing.Point(156, 163);
            this.txtParolaNoua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParolaNoua.Name = "txtParolaNoua";
            this.txtParolaNoua.PasswordChar = '*';
            this.txtParolaNoua.Size = new System.Drawing.Size(184, 22);
            this.txtParolaNoua.TabIndex = 7;
            // 
            // txtParolaVeche
            // 
            this.txtParolaVeche.Location = new System.Drawing.Point(156, 107);
            this.txtParolaVeche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParolaVeche.Name = "txtParolaVeche";
            this.txtParolaVeche.Size = new System.Drawing.Size(184, 22);
            this.txtParolaVeche.TabIndex = 6;
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(156, 45);
            this.txtUtilizator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(184, 22);
            this.txtUtilizator.TabIndex = 5;
            // 
            // lblParolaNoua
            // 
            this.lblParolaNoua.AutoSize = true;
            this.lblParolaNoua.Location = new System.Drawing.Point(36, 169);
            this.lblParolaNoua.Name = "lblParolaNoua";
            this.lblParolaNoua.Size = new System.Drawing.Size(83, 16);
            this.lblParolaNoua.TabIndex = 3;
            this.lblParolaNoua.Text = "Parola noua:";
            // 
            // lblParolaVeche
            // 
            this.lblParolaVeche.AutoSize = true;
            this.lblParolaVeche.Location = new System.Drawing.Point(36, 107);
            this.lblParolaVeche.Name = "lblParolaVeche";
            this.lblParolaVeche.Size = new System.Drawing.Size(90, 16);
            this.lblParolaVeche.TabIndex = 2;
            this.lblParolaVeche.Text = "Parola veche:";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(36, 45);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(97, 16);
            this.lblUtilizator.TabIndex = 1;
            this.lblUtilizator.Text = "Nume utilizator:";
            // 
            // ModificareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(445, 385);
            this.Controls.Add(this.signInGB);
            this.Name = "ModificareParola";
            this.Text = "ModificareParola";
            this.signInGB.ResumeLayout(false);
            this.signInGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox signInGB;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.TextBox txtParolaNoua;
        private System.Windows.Forms.TextBox txtParolaVeche;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.Label lblParolaNoua;
        private System.Windows.Forms.Label lblParolaVeche;
        private System.Windows.Forms.Label lblUtilizator;
    }
}