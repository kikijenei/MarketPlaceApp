namespace Proiect2
{
    partial class ActualizareCantitate
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
            this.actualizareBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.cantitateLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.nupCantitate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // actualizareBtn
            // 
            this.actualizareBtn.BackColor = System.Drawing.Color.Wheat;
            this.actualizareBtn.Location = new System.Drawing.Point(173, 186);
            this.actualizareBtn.Name = "actualizareBtn";
            this.actualizareBtn.Size = new System.Drawing.Size(114, 37);
            this.actualizareBtn.TabIndex = 0;
            this.actualizareBtn.Text = "Actualizare";
            this.actualizareBtn.UseVisualStyleBackColor = false;
            this.actualizareBtn.Click += new System.EventHandler(this.actualizareBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(55, 52);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(68, 16);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "ID produs:";
            // 
            // cantitateLbl
            // 
            this.cantitateLbl.AutoSize = true;
            this.cantitateLbl.Location = new System.Drawing.Point(55, 113);
            this.cantitateLbl.Name = "cantitateLbl";
            this.cantitateLbl.Size = new System.Drawing.Size(103, 16);
            this.cantitateLbl.TabIndex = 2;
            this.cantitateLbl.Text = "Cantitatea noua:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(184, 52);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(219, 22);
            this.idTxt.TabIndex = 3;
            // 
            // nupCantitate
            // 
            this.nupCantitate.Location = new System.Drawing.Point(184, 113);
            this.nupCantitate.Name = "nupCantitate";
            this.nupCantitate.Size = new System.Drawing.Size(96, 22);
            this.nupCantitate.TabIndex = 4;
            // 
            // ActualizareCantitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(472, 258);
            this.Controls.Add(this.nupCantitate);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.cantitateLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.actualizareBtn);
            this.Name = "ActualizareCantitate";
            this.Text = "ActualizareCantitate";
            ((System.ComponentModel.ISupportInitialize)(this.nupCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actualizareBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label cantitateLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.NumericUpDown nupCantitate;
    }
}