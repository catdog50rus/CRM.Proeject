namespace CRM.Proeject.WFI
{
    partial class CustomerForm
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
            this.textBoxCustomerForm = new System.Windows.Forms.TextBox();
            this.labelInputNameCustomer = new System.Windows.Forms.Label();
            this.buttonSaveCustomerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCustomerForm
            // 
            this.textBoxCustomerForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomerForm.Location = new System.Drawing.Point(92, 6);
            this.textBoxCustomerForm.Name = "textBoxCustomerForm";
            this.textBoxCustomerForm.Size = new System.Drawing.Size(250, 20);
            this.textBoxCustomerForm.TabIndex = 0;
            // 
            // labelInputNameCustomer
            // 
            this.labelInputNameCustomer.AutoSize = true;
            this.labelInputNameCustomer.Location = new System.Drawing.Point(12, 9);
            this.labelInputNameCustomer.Name = "labelInputNameCustomer";
            this.labelInputNameCustomer.Size = new System.Drawing.Size(74, 13);
            this.labelInputNameCustomer.TabIndex = 1;
            this.labelInputNameCustomer.Text = "Введите Имя";
            // 
            // buttonSaveCustomerForm
            // 
            this.buttonSaveCustomerForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveCustomerForm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveCustomerForm.Location = new System.Drawing.Point(267, 238);
            this.buttonSaveCustomerForm.Name = "buttonSaveCustomerForm";
            this.buttonSaveCustomerForm.Size = new System.Drawing.Size(75, 22);
            this.buttonSaveCustomerForm.TabIndex = 2;
            this.buttonSaveCustomerForm.Text = "Сохранить";
            this.buttonSaveCustomerForm.UseVisualStyleBackColor = true;
            this.buttonSaveCustomerForm.Click += new System.EventHandler(this.ButtonSaveCustomerForm_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 272);
            this.Controls.Add(this.buttonSaveCustomerForm);
            this.Controls.Add(this.labelInputNameCustomer);
            this.Controls.Add(this.textBoxCustomerForm);
            this.Name = "CustomerForm";
            this.Text = "Покупатель";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerForm;
        private System.Windows.Forms.Label labelInputNameCustomer;
        private System.Windows.Forms.Button buttonSaveCustomerForm;
    }
}