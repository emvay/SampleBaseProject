using Training.Business.Abstract;
using Training.Business.Concrete;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Concrete;

namespace Training.WindowsForms
{
    public partial class Form1 : Form
    {

        private IProductService _productService;
        private ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();

            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories(cmbFilterCategories);
            LoadCategories(cmbProductCategory);
        }

        private void LoadCategories(ComboBox cmb)
        {
            cmb.DataSource = _categoryService.GetAll();
            cmb.DisplayMember = "CategoryName";
            cmb.ValueMember = "CategoryID";
        }

        private void LoadProducts()
        {
            dgvSource.DataSource = _productService.GetAll();
        }

        private void txtProducts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtProducts.Text))
                {
                    dgvSource.DataSource = _productService.GetProductsByProductName(txtProducts.Text);
                }
                else
                {
                    LoadProducts();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSource.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cmbFilterCategories.SelectedValue));
            }
            catch
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = txtProductName.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    CategoryID = Convert.ToInt32(cmbProductCategory.SelectedValue),
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text)
                });
                MessageBox.Show("Product has been added succesfully");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow selectedRow in dgvSource.SelectedRows)
                {
                    Product product = new Product
                    {
                        ProductId = Convert.ToInt32(selectedRow.Cells[0].Value)
                    };
                    _productService.Delete(product);
                    MessageBox.Show("Product has been deleted succesfully");
                };
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    ProductId = Convert.ToInt32(dgvSource.CurrentRow.Cells[0].Value),
                    ProductName = txtProductName.Text,
                    CategoryID = Convert.ToInt32(cmbProductCategory.SelectedValue),
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text)
                };
                _productService.Update(product);
                MessageBox.Show("Product has been updated succesfully");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvSource_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row=dgvSource.CurrentRow;
            txtProductName.Text = row.Cells[1].Value.ToString();
            cmbProductCategory.SelectedValue = row.Cells[2].Value;
            txtQuantityPerUnit.Text = row.Cells[3].Value.ToString();
            txtUnitPrice.Text = row.Cells[4].Value.ToString();
            txtUnitsInStock.Text = row.Cells[5].Value.ToString();
        }
    }
}