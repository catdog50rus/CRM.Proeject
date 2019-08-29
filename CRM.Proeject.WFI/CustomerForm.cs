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
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            Customer = customer;
            textBoxCustomerForm.Text = Customer.Name;
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSaveCustomerForm_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                Customer.Name = textBoxCustomerForm.Text;
            }
            else
            {
                Customer = new Customer()
                {
                    Name = textBoxCustomerForm.Text
                };
            }
        }
    }
}
