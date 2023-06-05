using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29._1_Recap_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }
        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

            }
            
        }
        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(tbxSearch.Text)).ToList();
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbxSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(search);

            }
        }
    }
}
