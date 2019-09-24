namespace ToutEmbal
{
    partial class PageOfTabControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBTxDftAll = new System.Windows.Forms.TextBox();
            this.TBTxDft = new System.Windows.Forms.TextBox();
            this.TBNbBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBTxDftAll
            // 
            this.TBTxDftAll.Location = new System.Drawing.Point(240, 82);
            this.TBTxDftAll.Name = "TBTxDftAll";
            this.TBTxDftAll.ReadOnly = true;
            this.TBTxDftAll.Size = new System.Drawing.Size(62, 20);
            this.TBTxDftAll.TabIndex = 11;
            // 
            // TBTxDft
            // 
            this.TBTxDft.Location = new System.Drawing.Point(240, 46);
            this.TBTxDft.Name = "TBTxDft";
            this.TBTxDft.ReadOnly = true;
            this.TBTxDft.Size = new System.Drawing.Size(62, 20);
            this.TBTxDft.TabIndex = 10;
            // 
            // TBNbBox
            // 
            this.TBNbBox.Location = new System.Drawing.Point(240, 12);
            this.TBNbBox.Name = "TBNbBox";
            this.TBNbBox.ReadOnly = true;
            this.TBNbBox.Size = new System.Drawing.Size(62, 20);
            this.TBNbBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Taux de défaut depuis le démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Taux défaut heure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de caisses depuis le démarrage";
            // 
            // PageOfTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBTxDftAll);
            this.Controls.Add(this.TBTxDft);
            this.Controls.Add(this.TBNbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageOfTabControl";
            this.Size = new System.Drawing.Size(320, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBTxDftAll;
        private System.Windows.Forms.TextBox TBTxDft;
        private System.Windows.Forms.TextBox TBNbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
