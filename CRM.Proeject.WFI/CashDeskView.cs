using CRM.Proeject.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Proeject.WFI
{
    class CashDeskView
    {

        CashDesk cashDesk;

        public Label CashDeskName { get; set; }
        public NumericUpDown CashDeskSum { get; set; }
        public ProgressBar QueueLengthProgres { get; set; } 
        public Label ExitCustomer { get; set; }

        public CashDeskView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;

            CashDeskName = new Label();
            CashDeskSum = new NumericUpDown();
            QueueLengthProgres = new ProgressBar();
            ExitCustomer = new Label();


            // 
            // modelLabel
            // 
            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y + 33);
            CashDeskName.Name = "labelCashDeskName" + number;
            CashDeskName.Size = new System.Drawing.Size(35, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();
            // 
            // modelNumericUpDown
            // 
            CashDeskSum.Location = new System.Drawing.Point(x + 70, y + 31);
            CashDeskSum.Name = "NumericUpDownCashDeskSum" + number;
            CashDeskSum.Size = new System.Drawing.Size(120, 20);
            CashDeskSum.TabIndex = number;
            CashDeskSum.Maximum = 100000000000000000;

            // 
            // progressBar
            // 
            QueueLengthProgres.Location = new System.Drawing.Point(x + 225, y + 31);
            QueueLengthProgres.Maximum = cashDesk.MaxQueueLenght;
            QueueLengthProgres.Name = "progressBarQueueLengthProgres" + number;
            QueueLengthProgres.Size = new System.Drawing.Size(100, 23);
            QueueLengthProgres.TabIndex = number;
            QueueLengthProgres.Value = 0;

            // 
            // modelLabel
            // 
            ExitCustomer.AutoSize = true;
            ExitCustomer.Location = new System.Drawing.Point(x + 400, y + 33);
            ExitCustomer.Name = "labelExitCustomer" + number;
            ExitCustomer.Size = new System.Drawing.Size(35, 13);
            ExitCustomer.TabIndex = number;
            ExitCustomer.Text = "";
            
            cashDesk.CheckClosed += CashDesk_CheckClosed;
         }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            CashDeskSum.Invoke((Action)delegate 
            {
                CashDeskSum.Value += e.Price;
                QueueLengthProgres.Value = cashDesk.Count;
                ExitCustomer.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
