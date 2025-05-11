namespace Proiect2
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUitareParola = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUitareParola = new System.Windows.Forms.Button();
            this.lblUitatParola = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogin.Location = new System.Drawing.Point(216, 39);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(209, 44);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "BUN VENIT";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblusername.Location = new System.Drawing.Point(123, 131);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(89, 22);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Utilizator: ";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblParola.Location = new System.Drawing.Point(123, 194);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(67, 22);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola:";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(224, 131);
            this.txtUtilizator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(212, 22);
            this.txtUtilizator.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(224, 194);
            this.txtParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(212, 22);
            this.txtParola.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Wheat;
            this.btnLogin.Location = new System.Drawing.Point(492, 305);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 43);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Logare";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Wheat;
            this.btnExit.Location = new System.Drawing.Point(33, 305);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Iesire";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUitareParola
            // 
            this.lblUitareParola.AutoSize = true;
            this.lblUitareParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitareParola.Location = new System.Drawing.Point(179, 245);
            this.lblUitareParola.Name = "lblUitareParola";
            this.lblUitareParola.Size = new System.Drawing.Size(168, 18);
            this.lblUitareParola.TabIndex = 8;
            this.lblUitareParola.Text = "Nu ai cont? Inregistrare: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Location = new System.Drawing.Point(362, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUitareParola
            // 
            this.btnUitareParola.BackColor = System.Drawing.Color.Wheat;
            this.btnUitareParola.Location = new System.Drawing.Point(362, 273);
            this.btnUitareParola.Name = "btnUitareParola";
            this.btnUitareParola.Size = new System.Drawing.Size(75, 23);
            this.btnUitareParola.TabIndex = 10;
            this.btnUitareParola.Text = "->";
            this.btnUitareParola.UseVisualStyleBackColor = false;
            this.btnUitareParola.Click += new System.EventHandler(this.btnUitareParola_Click);
            // 
            // lblUitatParola
            // 
            this.lblUitatParola.AutoSize = true;
            this.lblUitatParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitatParola.Location = new System.Drawing.Point(179, 277);
            this.lblUitatParola.Name = "lblUitatParola";
            this.lblUitatParola.Size = new System.Drawing.Size(126, 18);
            this.lblUitatParola.TabIndex = 11;
            this.lblUitatParola.Text = "Modificare parola:";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "العربية",
            "Deutsch",
            "Español",
            "Français",
            "English"});
            this.languageComboBox.Location = new System.Drawing.Point(13, 13);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 24);
            this.languageComboBox.TabIndex = 12;
            //this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(638, 389);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.lblUitatParola);
            this.Controls.Add(this.btnUitareParola);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUitareParola);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUitareParola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUitareParola;
        private System.Windows.Forms.Label lblUitatParola;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}