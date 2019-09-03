namespace CRM.Proeject.WFI
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.closedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.sellerToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.checkToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mainMenuToolStripMenuItem.Text = "Меню";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.productToolStripMenuItem.Text = "Товар";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.productAddToolStripMenuItem.Text = "Добавить";
            this.productAddToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem_Click);
            // 
            // sellerToolStripMenuItem
            // 
            this.sellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerAddToolStripMenuItem1});
            this.sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            this.sellerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sellerToolStripMenuItem.Text = "Продавец";
            this.sellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // sellerAddToolStripMenuItem1
            // 
            this.sellerAddToolStripMenuItem1.Name = "sellerAddToolStripMenuItem1";
            this.sellerAddToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.sellerAddToolStripMenuItem1.Text = "Добавить";
            this.sellerAddToolStripMenuItem1.Click += new System.EventHandler(this.SellerAddToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddToolStripMenuItem2});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.customerToolStripMenuItem.Text = "Покупатель";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // customerAddToolStripMenuItem2
            // 
            this.customerAddToolStripMenuItem2.Name = "customerAddToolStripMenuItem2";
            this.customerAddToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.customerAddToolStripMenuItem2.Text = "Добавить";
            this.customerAddToolStripMenuItem2.Click += new System.EventHandler(this.CustomerAddToolStripMenuItem2_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.checkToolStripMenuItem.Text = "Чек";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.modelToolStripMenuItem.Text = "Моделирование";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // closedToolStripMenuItem
            // 
            this.closedToolStripMenuItem.Name = "closedToolStripMenuItem";
            this.closedToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.closedToolStripMenuItem.Text = "Выход";
            this.closedToolStripMenuItem.Click += new System.EventHandler(this.ClosedToolStripMenuItem_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 27);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(204, 394);
            this.listBoxProducts.TabIndex = 2;
            this.listBoxProducts.DoubleClick += new System.EventHandler(this.ListBoxProducts_DoubleClick);
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(255, 27);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(192, 342);
            this.listBoxCart.TabIndex = 3;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(255, 376);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(40, 13);
            this.labelSum.TabIndex = 4;
            this.labelSum.Text = "Итого:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerAddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerAddToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label labelSum;
    }
}

