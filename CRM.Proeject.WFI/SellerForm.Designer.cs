namespace CRM.Proeject.WFI
{
    partial class SellerForm
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
            this.textBoxSellerName = new System.Windows.Forms.TextBox();
            this.labelInputSellerName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSellerName
            // 
            this.textBoxSellerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSellerName.Location = new System.Drawing.Point(141, 6);
            this.textBoxSellerName.Name = "textBoxSellerName";
            this.textBoxSellerName.Size = new System.Drawing.Size(201, 20);
            this.textBoxSellerName.TabIndex = 0;
            // 
            // labelInputSellerName
            // 
            this.labelInputSellerName.AutoSize = true;
            this.labelInputSellerName.Location = new System.Drawing.Point(12, 9);
            this.labelInputSellerName.Name = "labelInputSellerName";
            this.labelInputSellerName.Size = new System.Drawing.Size(123, 13);
            this.labelInputSellerName.TabIndex = 1;
            this.labelInputSellerName.Text = "Введите имя продавца";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(267, 237);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 272);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelInputSellerName);
            this.Controls.Add(this.textBoxSellerName);
            this.Name = "SellerForm";
            this.Text = "Продавец";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSellerName;
        private System.Windows.Forms.Label labelInputSellerName;
        private System.Windows.Forms.Button buttonSave;
    }
}