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
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = textBoxProductName.Text,
                Price = numericProductPrice.Value,
                Count = Convert.ToInt32(numericProductCount.Value)
            };
        }
    }
}
