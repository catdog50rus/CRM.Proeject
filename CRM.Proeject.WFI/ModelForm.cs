using CRM.Proeject.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Proeject.WFI
{
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new ShopComputerModel();

        public ModelForm()
        {
            InitializeComponent();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            numericUpDownCustomSpeed.Value = model.CustomerSpeed;
            numericUpDownCashDeskSpeed.Value = model.CashDeskSpeed;
            
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            var cashDeskes = new List<CashDeskView>();
            for(int i = 0; i < model.CashDesks.Count; i++)
            {
                var desk = new CashDeskView(model.CashDesks[i], i, 12, i * 26);
                cashDeskes.Add(desk);
                Controls.Add(desk.CashDeskName);
                Controls.Add(desk.CashDeskSum);
                Controls.Add(desk.QueueLengthProgres);
                Controls.Add(desk.ExitCustomer);
            }

            model.Start();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        private void NumericUpDownCustomSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)numericUpDownCustomSpeed.Value;
        }

        private void NumericUpDownCashDeskSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)numericUpDownCashDeskSpeed.Value;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            model.Stop();
        }


    }
}
