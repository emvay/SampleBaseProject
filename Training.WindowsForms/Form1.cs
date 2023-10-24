using System.Linq;
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

            _productService= new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //IProductService productManager=new ProductManager(new EfProductDal());
            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            dgvSource.DataSource = _productService.GetAll();

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DataSource = _categoryService.GetAll();

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());

            dgvSource.DataSource = _productService.GetByCategory((int)cmbCategories.SelectedValue);

            //using (TrainingContext trainingContext = new TrainingContext())
            //{
            //    dgvSource.DataSource = trainingContext.Products.
            //        Where(p => p.CategoryID == (int)cmbCategories.SelectedValue).ToList();
            //}
        }

        private void txtProducts_TextChanged(object sender, EventArgs e)
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                dgvSource.DataSource = trainingContext.Products.
                    Where(p => p.ProductName.ToLower().Contains(txtProducts.Text)).ToList();
            }
        }
    }
}