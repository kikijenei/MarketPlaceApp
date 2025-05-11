namespace Proiect2
{
    partial class StergerePrroduse
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
            this.stergereBtn = new System.Windows.Forms.Button();
            this.denumireCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // denumireLbl
            // 
            this.denumireLbl.AutoSize = true;
            this.denumireLbl.Location = new System.Drawing.Point(30, 40);
            this.denumireLbl.Name = "denumireLbl";
            this.denumireLbl.Size = new System.Drawing.Size(56, 16);
            this.denumireLbl.TabIndex = 0;
            this.denumireLbl.Text = "Produs: ";
            // 
            // stergereBtn
            // 
            this.stergereBtn.BackColor = System.Drawing.Color.Wheat;
            this.stergereBtn.Location = new System.Drawing.Point(156, 87);
            this.stergereBtn.Name = "stergereBtn";
            this.stergereBtn.Size = new System.Drawing.Size(94, 35);
            this.stergereBtn.TabIndex = 1;
            this.stergereBtn.Text = "Stergere";
            this.stergereBtn.UseVisualStyleBackColor = false;
            // 
            // denumireCBox
            // 
            this.denumireCBox.FormattingEnabled = true;
            this.denumireCBox.Location = new System.Drawing.Point(110, 37);
            this.denumireCBox.Name = "denumireCBox";
            this.denumireCBox.Size = new System.Drawing.Size(193, 24);
            this.denumireCBox.TabIndex = 2;
            this.denumireCBox.SelectedIndexChanged += new System.EventHandler(this.denumireCBox_SelectedIndexChanged);
            // 
            // StergerePrroduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(399, 161);
            this.Controls.Add(this.denumireCBox);
            this.Controls.Add(this.stergereBtn);
            this.Controls.Add(this.denumireLbl);
            this.Name = "StergerePrroduse";
            this.Text = "StergerePrroduse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label denumireLbl;
        private System.Windows.Forms.Button stergereBtn;
        private System.Windows.Forms.ComboBox denumireCBox;
    }
}