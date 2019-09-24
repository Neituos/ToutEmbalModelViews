namespace ToutEmbal
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProd = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdItemSuspend = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdItemResume = new System.Windows.Forms.ToolStripMenuItem();
            this.TCProd = new System.Windows.Forms.TabControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStripStartItemAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripPauseItemAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripResumeItemAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemProd});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(537, 24);
            this.MenuMain.TabIndex = 11;
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItemAdd});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(54, 20);
            this.MenuItemFile.Text = "Fichier";
            // 
            // FileItemAdd
            // 
            this.FileItemAdd.Name = "FileItemAdd";
            this.FileItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileItemAdd.Size = new System.Drawing.Size(180, 22);
            this.FileItemAdd.Text = "Ajouter";
            this.FileItemAdd.Click += new System.EventHandler(this.AddProductClick);
            // 
            // MenuItemProd
            // 
            this.MenuItemProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdItemStart,
            this.ProdItemSuspend,
            this.ProdItemResume});
            this.MenuItemProd.Name = "MenuItemProd";
            this.MenuItemProd.Size = new System.Drawing.Size(78, 20);
            this.MenuItemProd.Text = "Production";
            // 
            // ProdItemStart
            // 
            this.ProdItemStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStartItemAll});
            this.ProdItemStart.Name = "ProdItemStart";
            this.ProdItemStart.Size = new System.Drawing.Size(180, 22);
            this.ProdItemStart.Text = "Démarrer";
            // 
            // ProdItemSuspend
            // 
            this.ProdItemSuspend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripPauseItemAll});
            this.ProdItemSuspend.Name = "ProdItemSuspend";
            this.ProdItemSuspend.Size = new System.Drawing.Size(180, 22);
            this.ProdItemSuspend.Text = "Suspendre";
            // 
            // ProdItemResume
            // 
            this.ProdItemResume.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripResumeItemAll});
            this.ProdItemResume.Name = "ProdItemResume";
            this.ProdItemResume.Size = new System.Drawing.Size(180, 22);
            this.ProdItemResume.Text = "Rependre";
            // 
            // TCProd
            // 
            this.TCProd.Location = new System.Drawing.Point(166, 80);
            this.TCProd.Name = "TCProd";
            this.TCProd.SelectedIndex = 0;
            this.TCProd.Size = new System.Drawing.Size(327, 153);
            this.TCProd.TabIndex = 3;
            // 
            // ToolStripStartItemAll
            // 
            this.ToolStripStartItemAll.Name = "ToolStripStartItemAll";
            this.ToolStripStartItemAll.Size = new System.Drawing.Size(180, 22);
            this.ToolStripStartItemAll.Text = "Tout";
            this.ToolStripStartItemAll.Click += new System.EventHandler(this.StartAllClick);
            // 
            // ToolStripPauseItemAll
            // 
            this.ToolStripPauseItemAll.Name = "ToolStripPauseItemAll";
            this.ToolStripPauseItemAll.Size = new System.Drawing.Size(180, 22);
            this.ToolStripPauseItemAll.Text = "Tout";
            this.ToolStripPauseItemAll.Click += new System.EventHandler(this.PauseAllClick);
            // 
            // ToolStripResumeItemAll
            // 
            this.ToolStripResumeItemAll.Name = "ToolStripResumeItemAll";
            this.ToolStripResumeItemAll.Size = new System.Drawing.Size(180, 22);
            this.ToolStripResumeItemAll.Text = "Tout";
            this.ToolStripResumeItemAll.Click += new System.EventHandler(this.ResumeAllClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 401);
            this.Controls.Add(this.MenuMain);
            this.Controls.Add(this.TCProd);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production des caisses";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem FileItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProd;
        private System.Windows.Forms.ToolStripMenuItem ProdItemStart;
        private System.Windows.Forms.ToolStripMenuItem ProdItemSuspend;
        private System.Windows.Forms.ToolStripMenuItem ProdItemResume;
        private System.Windows.Forms.TabControl TCProd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripStartItemAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripPauseItemAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripResumeItemAll;
    }
}

