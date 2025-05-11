namespace Proiect2
{
    partial class Form2
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
            this.produseGridView = new System.Windows.Forms.DataGridView();
            this.produseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produseGridView
            // 
            this.produseGridView.AllowUserToOrderColumns = true;
            this.produseGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.produseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseGridView.Location = new System.Drawing.Point(41, 81);
            this.produseGridView.Name = "produseGridView";
            this.produseGridView.RowHeadersWidth = 51;
            this.produseGridView.RowTemplate.Height = 24;
            this.produseGridView.Size = new System.Drawing.Size(451, 315);
            this.produseGridView.TabIndex = 2;
            this.produseGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produseGridView_CellDoubleClick);
            // 
            // produseBtn
            // 
            this.produseBtn.BackColor = System.Drawing.Color.Wheat;
            this.produseBtn.Location = new System.Drawing.Point(41, 23);
            this.produseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.produseBtn.Name = "produseBtn";
            this.produseBtn.Size = new System.Drawing.Size(241, 42);
            this.produseBtn.TabIndex = 3;
            this.produseBtn.Text = "Vizualizare produse disponibile";
            this.produseBtn.UseVisualStyleBackColor = false;
            this.produseBtn.Click += new System.EventHandler(this.produseBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(527, 439);
            this.Controls.Add(this.produseBtn);
            this.Controls.Add(this.produseGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView produseGridView;
        private System.Windows.Forms.Button produseBtn;
    }
}