namespace CRM.Proeject.WFI
{
    partial class ModelForm
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
            this.BeginButton = new System.Windows.Forms.Button();
            this.numericUpDownCustomSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCashDeskSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelCustomSpeed = new System.Windows.Forms.Label();
            this.labelCashDeskSpeed = new System.Windows.Forms.Label();
            this.labelSetting = new System.Windows.Forms.Label();
            this.labelCashDesk = new System.Windows.Forms.Label();
            this.labelCashDeskSum = new System.Windows.Forms.Label();
            this.labelCashDeskQueue = new System.Windows.Forms.Label();
            this.labelExitCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCashDeskSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // BeginButton
            // 
            this.BeginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BeginButton.Location = new System.Drawing.Point(529, 415);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(75, 23);
            this.BeginButton.TabIndex = 0;
            this.BeginButton.Text = "Начать";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // numericUpDownCustomSpeed
            // 
            this.numericUpDownCustomSpeed.Location = new System.Drawing.Point(668, 31);
            this.numericUpDownCustomSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCustomSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCustomSpeed.Name = "numericUpDownCustomSpeed";
            this.numericUpDownCustomSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCustomSpeed.TabIndex = 1;
            this.numericUpDownCustomSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCustomSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownCustomSpeed_ValueChanged);
            // 
            // numericUpDownCashDeskSpeed
            // 
            this.numericUpDownCashDeskSpeed.Location = new System.Drawing.Point(668, 58);
            this.numericUpDownCashDeskSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.Name = "numericUpDownCashDeskSpeed";
            this.numericUpDownCashDeskSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCashDeskSpeed.TabIndex = 2;
            this.numericUpDownCashDeskSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownCashDeskSpeed_ValueChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(713, 415);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Остановить";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // labelCustomSpeed
            // 
            this.labelCustomSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomSpeed.AutoSize = true;
            this.labelCustomSpeed.Location = new System.Drawing.Point(490, 33);
            this.labelCustomSpeed.Name = "labelCustomSpeed";
            this.labelCustomSpeed.Size = new System.Drawing.Size(172, 13);
            this.labelCustomSpeed.TabIndex = 4;
            this.labelCustomSpeed.Text = "Частота генерации покупателей";
            // 
            // labelCashDeskSpeed
            // 
            this.labelCashDeskSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCashDeskSpeed.AutoSize = true;
            this.labelCashDeskSpeed.Location = new System.Drawing.Point(539, 60);
            this.labelCashDeskSpeed.Name = "labelCashDeskSpeed";
            this.labelCashDeskSpeed.Size = new System.Drawing.Size(123, 13);
            this.labelCashDeskSpeed.TabIndex = 5;
            this.labelCashDeskSpeed.Text = "Время обработки касс";
            // 
            // labelSetting
            // 
            this.labelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(581, 9);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(103, 13);
            this.labelSetting.TabIndex = 6;
            this.labelSetting.Text = "Настройки модели";
            // 
            // labelCashDesk
            // 
            this.labelCashDesk.AutoSize = true;
            this.labelCashDesk.Location = new System.Drawing.Point(22, 9);
            this.labelCashDesk.Name = "labelCashDesk";
            this.labelCashDesk.Size = new System.Drawing.Size(38, 13);
            this.labelCashDesk.TabIndex = 7;
            this.labelCashDesk.Text = "Касса";
            // 
            // labelCashDeskSum
            // 
            this.labelCashDeskSum.AutoSize = true;
            this.labelCashDeskSum.Location = new System.Drawing.Point(109, 9);
            this.labelCashDeskSum.Name = "labelCashDeskSum";
            this.labelCashDeskSum.Size = new System.Drawing.Size(50, 13);
            this.labelCashDeskSum.TabIndex = 8;
            this.labelCashDeskSum.Text = "Выручка";
            // 
            // labelCashDeskQueue
            // 
            this.labelCashDeskQueue.AutoSize = true;
            this.labelCashDeskQueue.Location = new System.Drawing.Point(240, 9);
            this.labelCashDeskQueue.Name = "labelCashDeskQueue";
            this.labelCashDeskQueue.Size = new System.Drawing.Size(91, 13);
            this.labelCashDeskQueue.TabIndex = 9;
            this.labelCashDeskQueue.Text = "Очередь в кассу";
            // 
            // labelExitCustomer
            // 
            this.labelExitCustomer.AutoSize = true;
            this.labelExitCustomer.Location = new System.Drawing.Point(371, 9);
            this.labelExitCustomer.Name = "labelExitCustomer";
            this.labelExitCustomer.Size = new System.Drawing.Size(102, 13);
            this.labelExitCustomer.TabIndex = 10;
            this.labelExitCustomer.Text = "Ушло покупателей";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExitCustomer);
            this.Controls.Add(this.labelCashDeskQueue);
            this.Controls.Add(this.labelCashDeskSum);
            this.Controls.Add(this.labelCashDesk);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.labelCashDeskSpeed);
            this.Controls.Add(this.labelCustomSpeed);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.numericUpDownCashDeskSpeed);
            this.Controls.Add(this.numericUpDownCustomSpeed);
            this.Controls.Add(this.BeginButton);
            this.Name = "ModelForm";
            this.Text = "Моделирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCashDeskSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownCashDeskSpeed;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelCustomSpeed;
        private System.Windows.Forms.Label labelCashDeskSpeed;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.Label labelCashDesk;
        private System.Windows.Forms.Label labelCashDeskSum;
        private System.Windows.Forms.Label labelCashDeskQueue;
        private System.Windows.Forms.Label labelExitCustomer;
    }
}