namespace CRM.Proeject.WFI
{
    partial class ProductForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelInpetProdictName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.numericProductPrice = new System.Windows.Forms.NumericUpDown();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelInputProductCount = new System.Windows.Forms.Label();
            this.numericProductCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(267, 237);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelInpetProdictName
            // 
            this.labelInpetProdictName.AutoSize = true;
            this.labelInpetProdictName.Location = new System.Drawing.Point(12, 15);
            this.labelInpetProdictName.Name = "labelInpetProdictName";
            this.labelInpetProdictName.Size = new System.Drawing.Size(164, 13);
            this.labelInpetProdictName.TabIndex = 1;
            this.labelInpetProdictName.Text = "Введите наименование товара";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductName.Location = new System.Drawing.Point(182, 12);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(160, 20);
            this.textBoxProductName.TabIndex = 2;
            // 
            // numericProductPrice
            // 
            this.numericProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericProductPrice.DecimalPlaces = 2;
            this.numericProductPrice.Location = new System.Drawing.Point(182, 39);
            this.numericProductPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericProductPrice.Name = "numericProductPrice";
            this.numericProductPrice.Size = new System.Drawing.Size(160, 20);
            this.numericProductPrice.TabIndex = 3;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(12, 41);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(112, 13);
            this.labelProductPrice.TabIndex = 4;
            this.labelProductPrice.Text = "Введите цену товару";
            // 
            // labelInputProductCount
            // 
            this.labelInputProductCount.AutoSize = true;
            this.labelInputProductCount.Location = new System.Drawing.Point(12, 68);
            this.labelInputProductCount.Name = "labelInputProductCount";
            this.labelInputProductCount.Size = new System.Drawing.Size(110, 13);
            this.labelInputProductCount.TabIndex = 5;
            this.labelInputProductCount.Text = "Введите количество";
            // 
            // numericProductCount
            // 
            this.numericProductCount.Location = new System.Drawing.Point(182, 66);
            this.numericProductCount.Name = "numericProductCount";
            this.numericProductCount.Size = new System.Drawing.Size(160, 20);
            this.numericProductCount.TabIndex = 6;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 272);
            this.Controls.Add(this.numericProductCount);
            this.Controls.Add(this.labelInputProductCount);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.numericProductPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelInpetProdictName);
            this.Controls.Add(this.buttonSave);
            this.Name = "ProductForm";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelInpetProdictName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.NumericUpDown numericProductPrice;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelInputProductCount;
        private System.Windows.Forms.NumericUpDown numericProductCount;
    }
}