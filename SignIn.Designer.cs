namespace Proiect2
{
    partial class SignIn
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
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblConfirmareParola = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtConfirmareParola = new System.Windows.Forms.TextBox();
            this.bnSalvare = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.RadioButton();
            this.btnUtilizator = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.signInGB = new System.Windows.Forms.GroupBox();
            this.signInGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(36, 83);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(97, 16);
            this.lblUtilizator.TabIndex = 1;
            this.lblUtilizator.Text = "Nume utilizator:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(36, 145);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(50, 16);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola:";
            // 
            // lblConfirmareParola
            // 
            this.lblConfirmareParola.AutoSize = true;
            this.lblConfirmareParola.Location = new System.Drawing.Point(36, 207);
            this.lblConfirmareParola.Name = "lblConfirmareParola";
            this.lblConfirmareParola.Size = new System.Drawing.Size(117, 16);
            this.lblConfirmareParola.TabIndex = 3;
            this.lblConfirmareParola.Text = "Confirmare parola:";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(156, 83);
            this.txtUtilizator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(184, 22);
            this.txtUtilizator.TabIndex = 5;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(156, 145);
            this.txtParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(184, 22);
            this.txtParola.TabIndex = 6;
            // 
            // txtConfirmareParola
            // 
            this.txtConfirmareParola.Location = new System.Drawing.Point(156, 201);
            this.txtConfirmareParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmareParola.Name = "txtConfirmareParola";
            this.txtConfirmareParola.PasswordChar = '*';
            this.txtConfirmareParola.Size = new System.Drawing.Size(184, 22);
            this.txtConfirmareParola.TabIndex = 7;
            // 
            // bnSalvare
            // 
            this.bnSalvare.BackColor = System.Drawing.Color.Wheat;
            this.bnSalvare.Location = new System.Drawing.Point(221, 253);
            this.bnSalvare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnSalvare.Name = "bnSalvare";
            this.bnSalvare.Size = new System.Drawing.Size(97, 36);
            this.bnSalvare.TabIndex = 8;
            this.bnSalvare.Text = "Salvare";
            this.bnSalvare.UseVisualStyleBackColor = false;
            this.bnSalvare.Click += new System.EventHandler(this.bnSalvare_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Wheat;
            this.btnInapoi.Location = new System.Drawing.Point(81, 253);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(97, 36);
            this.btnInapoi.TabIndex = 9;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.Location = new System.Drawing.Point(174, 39);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(66, 20);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.TabStop = true;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnUtilizator
            // 
            this.btnUtilizator.AutoSize = true;
            this.btnUtilizator.Location = new System.Drawing.Point(261, 39);
            this.btnUtilizator.Name = "btnUtilizator";
            this.btnUtilizator.Size = new System.Drawing.Size(79, 20);
            this.btnUtilizator.TabIndex = 11;
            this.btnUtilizator.TabStop = true;
            this.btnUtilizator.Text = "Utilizator";
            this.btnUtilizator.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(36, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Ce sunt:";
            // 
            // signInGB
            // 
            this.signInGB.Controls.Add(this.lblStatus);
            this.signInGB.Controls.Add(this.btnUtilizator);
            this.signInGB.Controls.Add(this.btnAdmin);
            this.signInGB.Controls.Add(this.btnInapoi);
            this.signInGB.Controls.Add(this.bnSalvare);
            this.signInGB.Controls.Add(this.txtConfirmareParola);
            this.signInGB.Controls.Add(this.txtParola);
            this.signInGB.Controls.Add(this.txtUtilizator);
            this.signInGB.Controls.Add(this.lblConfirmareParola);
            this.signInGB.Controls.Add(this.lblParola);
            this.signInGB.Controls.Add(this.lblUtilizator);
            this.signInGB.Location = new System.Drawing.Point(34, 38);
            this.signInGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInGB.Name = "signInGB";
            this.signInGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInGB.Size = new System.Drawing.Size(400, 328);
            this.signInGB.TabIndex = 0;
            this.signInGB.TabStop = false;
            this.signInGB.Text = "Sign In ";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(480, 405);
            this.Controls.Add(this.signInGB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.signInGB.ResumeLayout(false);
            this.signInGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblConfirmareParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtConfirmareParola;
        private System.Windows.Forms.Button bnSalvare;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.RadioButton btnAdmin;
        private System.Windows.Forms.RadioButton btnUtilizator;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox signInGB;
    }
}