using Training.Business.Abstract;
using Training.Business.Concrete;
using Training.DataAccess.Concrete.EntityFramework;

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
            LoadCategories();
        }

        private void LoadCategories()
        {
            cmbCategories.DataSource = _categoryService.GetAll();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
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
            catch
            {

            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSource.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cmbCategories.SelectedValue));
            }
            catch
            {

            }

        }
    }
}