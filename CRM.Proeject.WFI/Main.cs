using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Proeject.BL.Model;

namespace CRM.Proeject.WFI
{
    public partial class Main : Form
    {
        CrmContext db;
        Cart cart;
        Customer customer;
        
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();

            cart = new Cart(customer);
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks, db);
            catalogCheck.Show();
        }

        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void SellerAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        public void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                listBoxProducts.Invoke((Action)delegate
               {
                   UpdateLists();
               });
            });
        }

        private void ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.Show();
        }

        private void ClosedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxProducts.SelectedItem is Product product)
            {
                cart.Add(product);
                listBoxCart.Items.Add(product);
                labelSum.Text = "Итого :" + cart.Sum;
            }
        }

        private void UpdateLists()
        {
            listBoxProducts.Items.AddRange(db.Products.ToArray());
            listBoxCart.Items.AddRange(cart.GetAll().ToArray());
        }
    }
}
