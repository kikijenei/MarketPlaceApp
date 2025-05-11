namespace Proiect2
{
    partial class Form1
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
            this.adaugareBtn = new System.Windows.Forms.Button();
            this.produseGridView = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToateProduseleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareUtilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereUtilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriiCBox = new System.Windows.Forms.ComboBox();
            this.catlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adaugareBtn
            // 
            this.adaugareBtn.BackColor = System.Drawing.Color.Wheat;
            this.adaugareBtn.Location = new System.Drawing.Point(33, 54);
            this.adaugareBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adaugareBtn.Name = "adaugareBtn";
            this.adaugareBtn.Size = new System.Drawing.Size(137, 39);
            this.adaugareBtn.TabIndex = 0;
            this.adaugareBtn.Text = "Adaugare Produs";
            this.adaugareBtn.UseVisualStyleBackColor = false;
            this.adaugareBtn.Click += new System.EventHandler(this.adaugareBtn_Click);
            // 
            // produseGridView
            // 
            this.produseGridView.AllowUserToOrderColumns = true;
            this.produseGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.produseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseGridView.Location = new System.Drawing.Point(33, 100);
            this.produseGridView.Name = "produseGridView";
            this.produseGridView.RowHeadersWidth = 51;
            this.produseGridView.RowTemplate.Height = 24;
            this.produseGridView.Size = new System.Drawing.Size(648, 310);
            this.produseGridView.TabIndex = 1;
            this.produseGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produseGridView_CellDoubleClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refreshBtn.Location = new System.Drawing.Point(610, 53);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(71, 40);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.vizualizareToateProduseleToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.infoToolStripMenuItem1,
            this.menu2toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProduseToolStripMenuItem,
            this.vanzareProduseToolStripMenuItem,
            this.cautareProduseToolStripMenuItem,
            this.stergereProToolStripMenuItem,
            this.adaugareCategorieToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Apple_Red_512;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // adaugareProduseToolStripMenuItem
            // 
            this.adaugareProduseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsNouToolStripMenuItem,
            this.actualizareCantitateToolStripMenuItem});
            this.adaugareProduseToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Strawberry_512;
            this.adaugareProduseToolStripMenuItem.Name = "adaugareProduseToolStripMenuItem";
            this.adaugareProduseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugareProduseToolStripMenuItem.Text = "Adaugare produse";
            // 
            // produsNouToolStripMenuItem
            // 
            this.produsNouToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Grape_512;
            this.produsNouToolStripMenuItem.Name = "produsNouToolStripMenuItem";
            this.produsNouToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.produsNouToolStripMenuItem.Text = "Produs nou";
            this.produsNouToolStripMenuItem.Click += new System.EventHandler(this.produsNouToolStripMenuItem_Click);
            // 
            // actualizareCantitateToolStripMenuItem
            // 
            this.actualizareCantitateToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Watermelon_512;
            this.actualizareCantitateToolStripMenuItem.Name = "actualizareCantitateToolStripMenuItem";
            this.actualizareCantitateToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.actualizareCantitateToolStripMenuItem.Text = "Actualizare cantitate";
            this.actualizareCantitateToolStripMenuItem.Click += new System.EventHandler(this.actualizareCantitateToolStripMenuItem_Click);
            // 
            // vanzareProduseToolStripMenuItem
            // 
            this.vanzareProduseToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Avocado_512;
            this.vanzareProduseToolStripMenuItem.Name = "vanzareProduseToolStripMenuItem";
            this.vanzareProduseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vanzareProduseToolStripMenuItem.Text = "Vanzare produse";
            this.vanzareProduseToolStripMenuItem.Click += new System.EventHandler(this.vanzareProduseToolStripMenuItem_Click);
            // 
            // cautareProduseToolStripMenuItem
            // 
            this.cautareProduseToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Paomedia_Small_N_Flat_Search_512;
            this.cautareProduseToolStripMenuItem.Name = "cautareProduseToolStripMenuItem";
            this.cautareProduseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cautareProduseToolStripMenuItem.Text = "Cautare produse";
            this.cautareProduseToolStripMenuItem.Click += new System.EventHandler(this.cautareProduseToolStripMenuItem_Click);
            // 
            // stergereProToolStripMenuItem
            // 
            this.stergereProToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Blackcurrant_512;
            this.stergereProToolStripMenuItem.Name = "stergereProToolStripMenuItem";
            this.stergereProToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergereProToolStripMenuItem.Text = "Stergere produse";
            this.stergereProToolStripMenuItem.Click += new System.EventHandler(this.stergereProToolStripMenuItem_Click);
            // 
            // adaugareCategorieToolStripMenuItem
            // 
            this.adaugareCategorieToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Kiwifruit_512;
            this.adaugareCategorieToolStripMenuItem.Name = "adaugareCategorieToolStripMenuItem";
            this.adaugareCategorieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugareCategorieToolStripMenuItem.Text = "Adaugare categorie";
            this.adaugareCategorieToolStripMenuItem.Click += new System.EventHandler(this.adaugareCategorieToolStripMenuItem_Click);
            // 
            // vizualizareToateProduseleToolStripMenuItem
            // 
            this.vizualizareToateProduseleToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Apple_Yellow_512;
            this.vizualizareToateProduseleToolStripMenuItem.Name = "vizualizareToateProduseleToolStripMenuItem";
            this.vizualizareToateProduseleToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.vizualizareToateProduseleToolStripMenuItem.Text = "Vizualizare toate produsele";
            this.vizualizareToateProduseleToolStripMenuItem.Click += new System.EventHandler(this.vizualizareToateProduseleToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Iconarchive_Fruit_Soft_Illustration_Apple_Green_512;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.infoToolStripMenuItem.Text = "Istoric vanzari";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Image = global::Proiect2.Properties.Resources.Paomedia_Small_N_Flat_Sign_info_512;
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(69, 24);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            // 
            // menu2toolStripMenuItem
            // 
            this.menu2toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu2toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareUtilizatoriToolStripMenuItem,
            this.cautareUtilizatorToolStripMenuItem,
            this.stergereUtilizatorToolStripMenuItem});
            this.menu2toolStripMenuItem.Image = global::Proiect2.Properties.Resources.Paomedia_Small_N_Flat_Profile_512;
            this.menu2toolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu2toolStripMenuItem.Name = "menu2toolStripMenuItem";
            this.menu2toolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.menu2toolStripMenuItem.Text = "Menu";
            this.menu2toolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // afisareUtilizatoriToolStripMenuItem
            // 
            this.afisareUtilizatoriToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Paomedia_Small_N_Flat_Sign_add_512;
            this.afisareUtilizatoriToolStripMenuItem.Name = "afisareUtilizatoriToolStripMenuItem";
            this.afisareUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afisareUtilizatoriToolStripMenuItem.Text = "Afisare utilizatori";
            this.afisareUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.afisareUtilizatoriToolStripMenuItem_Click);
            // 
            // cautareUtilizatorToolStripMenuItem
            // 
            this.cautareUtilizatorToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Paomedia_Small_N_Flat_Search_512;
            this.cautareUtilizatorToolStripMenuItem.Name = "cautareUtilizatorToolStripMenuItem";
            this.cautareUtilizatorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cautareUtilizatorToolStripMenuItem.Text = "Cautare utilizator";
            this.cautareUtilizatorToolStripMenuItem.Click += new System.EventHandler(this.cautareUtilizatorToolStripMenuItem_Click);
            // 
            // stergereUtilizatorToolStripMenuItem
            // 
            this.stergereUtilizatorToolStripMenuItem.Image = global::Proiect2.Properties.Resources.Paomedia_Small_N_Flat_Sign_delete_512;
            this.stergereUtilizatorToolStripMenuItem.Name = "stergereUtilizatorToolStripMenuItem";
            this.stergereUtilizatorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergereUtilizatorToolStripMenuItem.Text = "Stergere utilizator";
            this.stergereUtilizatorToolStripMenuItem.Click += new System.EventHandler(this.stergereUtilizatorToolStripMenuItem_Click);
            // 
            // categoriiCBox
            // 
            this.categoriiCBox.FormattingEnabled = true;
            this.categoriiCBox.Location = new System.Drawing.Point(560, 427);
            this.categoriiCBox.Name = "categoriiCBox";
            this.categoriiCBox.Size = new System.Drawing.Size(121, 24);
            this.categoriiCBox.TabIndex = 4;
            this.categoriiCBox.SelectedIndexChanged += new System.EventHandler(this.categoriiCBox_SelectedIndexChanged);
            // 
            // catlbl
            // 
            this.catlbl.AutoSize = true;
            this.catlbl.Location = new System.Drawing.Point(430, 430);
            this.catlbl.Name = "catlbl";
            this.catlbl.Size = new System.Drawing.Size(115, 16);
            this.catlbl.TabIndex = 5;
            this.catlbl.Text = "Lista de categorii: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(719, 483);
            this.Controls.Add(this.catlbl);
            this.Controls.Add(this.categoriiCBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.produseGridView);
            this.Controls.Add(this.adaugareBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina principala";
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugareBtn;
        private System.Windows.Forms.DataGridView produseGridView;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToateProduseleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareCategorieToolStripMenuItem;
        private System.Windows.Forms.ComboBox categoriiCBox;
        private System.Windows.Forms.Label catlbl;
        private System.Windows.Forms.ToolStripMenuItem menu2toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareUtilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereUtilizatorToolStripMenuItem;
    }
}

