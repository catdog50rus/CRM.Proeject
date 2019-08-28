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
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSaveSellerForm_Click(object sender, EventArgs e)
        {
            Seller = new Seller()
            {
                Name = textBoxSellerNameSellerForm.Text
            };
        }
    }
}
