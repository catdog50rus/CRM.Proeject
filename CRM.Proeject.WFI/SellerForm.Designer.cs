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
            this.textBoxSellerNameSellerForm = new System.Windows.Forms.TextBox();
            this.labelInputSellerName = new System.Windows.Forms.Label();
            this.buttonSaveSellerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSellerNameSellerForm
            // 
            this.textBoxSellerNameSellerForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSellerNameSellerForm.Location = new System.Drawing.Point(141, 6);
            this.textBoxSellerNameSellerForm.Name = "textBoxSellerNameSellerForm";
            this.textBoxSellerNameSellerForm.Size = new System.Drawing.Size(201, 20);
            this.textBoxSellerNameSellerForm.TabIndex = 0;
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
            // buttonSaveSellerForm
            // 
            this.buttonSaveSellerForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSellerForm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveSellerForm.Location = new System.Drawing.Point(267, 237);
            this.buttonSaveSellerForm.Name = "buttonSaveSellerForm";
            this.buttonSaveSellerForm.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSellerForm.TabIndex = 2;
            this.buttonSaveSellerForm.Text = "Сохранить";
            this.buttonSaveSellerForm.UseVisualStyleBackColor = true;
            this.buttonSaveSellerForm.Click += new System.EventHandler(this.ButtonSaveSellerForm_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 272);
            this.Controls.Add(this.buttonSaveSellerForm);
            this.Controls.Add(this.labelInputSellerName);
            this.Controls.Add(this.textBoxSellerNameSellerForm);
            this.Name = "SellerForm";
            this.Text = "Продавец";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSellerNameSellerForm;
        private System.Windows.Forms.Label labelInputSellerName;
        private System.Windows.Forms.Button buttonSaveSellerForm;
    }
}