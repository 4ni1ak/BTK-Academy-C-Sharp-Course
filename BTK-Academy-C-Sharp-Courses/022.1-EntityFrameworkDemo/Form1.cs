using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022._1_EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdbtnSearchName.Checked = true;

        }
        ProductDal _productDal= new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (ETradeContext context = new ETradeContext())
            {
                LoadProducts();

            }
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            //var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            //dgwProducts.DataSource=result;
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }
        private void SearchProductsCompanyName(string key)
        {
            //var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            //dgwProducts.DataSource=result;
            var result = _productDal.GetByCompany(key);
            dgwProducts.DataSource = result;
        }
      
        private void SearchProductsId(int key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = context.Products.FirstOrDefault(p => p.Id == key);
                dgwProducts.DataSource = result != null ? new List<Product> { result } : null;
            }

        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Company= tbxCompanyAdd.Text,

                Name = tbxName.Text,
                
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),

                StockAmount=Convert.ToInt32(tbxStockAmount.Text) 
            });
            MessageBox.Show("Added");
            LoadProducts();
            
        }
     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product { 
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Company = tbxCompanyUpdate.Text,
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            }) ;
            LoadProducts();
            MessageBox.Show("Updated");
        }


        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCompanyUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            }); 
            LoadProducts();

            MessageBox.Show("Deleted");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnSearchName.Checked == true)
            {
                SearchProducts(tbxSearch.Text);
            }
            else if (rdbtnSearchId.Checked == true)
            {
                try
                {
                    SearchProductsId(Convert.ToInt32(tbxSearch.Text));
                }
                catch (Exception)
                {

                    MessageBox.Show("Please enter a Id");
                } 
            }
            else if (rdbtnSearchCompany.Checked == true)
            {
                SearchProductsCompanyName(tbxSearch.Text);
            }
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(2);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SearchProductsId(Convert.ToInt32(tbxSearch.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a Id");
            }
            
        }

        private void rdbtnSearchCompany_CheckedChanged(object sender, EventArgs e)
        {
                SearchProductsCompanyName(tbxSearch.Text);
        }

        private void rdbtnSearchName_CheckedChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
