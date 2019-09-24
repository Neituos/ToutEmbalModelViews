namespace ToutEmbal
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNameProduct = new System.Windows.Forms.TextBox();
            this.TBSpeedProduct = new System.Windows.Forms.TextBox();
            this.TBNumberOfProduct = new System.Windows.Forms.TextBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.BValidate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la production";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre total de caisse a faire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vitesse de production";
            // 
            // TBNameProduct
            // 
            this.TBNameProduct.Location = new System.Drawing.Point(183, 28);
            this.TBNameProduct.Name = "TBNameProduct";
            this.TBNameProduct.Size = new System.Drawing.Size(100, 20);
            this.TBNameProduct.TabIndex = 1;
            // 
            // TBSpeedProduct
            // 
            this.TBSpeedProduct.Location = new System.Drawing.Point(183, 120);
            this.TBSpeedProduct.Name = "TBSpeedProduct";
            this.TBSpeedProduct.Size = new System.Drawing.Size(100, 20);
            this.TBSpeedProduct.TabIndex = 3;
            // 
            // TBNumberOfProduct
            // 
            this.TBNumberOfProduct.Location = new System.Drawing.Point(183, 74);
            this.TBNumberOfProduct.Name = "TBNumberOfProduct";
            this.TBNumberOfProduct.Size = new System.Drawing.Size(100, 20);
            this.TBNumberOfProduct.TabIndex = 2;
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(173, 168);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Annuler";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancelClick);
            // 
            // BValidate
            // 
            this.BValidate.Location = new System.Drawing.Point(38, 168);
            this.BValidate.Name = "BValidate";
            this.BValidate.Size = new System.Drawing.Size(75, 23);
            this.BValidate.TabIndex = 4;
            this.BValidate.Text = "Valider";
            this.BValidate.UseVisualStyleBackColor = false;
            this.BValidate.Click += new System.EventHandler(this.BValidateClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.BValidate);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.TBNumberOfProduct);
            this.Controls.Add(this.TBSpeedProduct);
            this.Controls.Add(this.TBNameProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout d\'une production";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNameProduct;
        private System.Windows.Forms.TextBox TBSpeedProduct;
        private System.Windows.Forms.TextBox TBNumberOfProduct;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BValidate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}