using System.Linq;
using Training.Business.Concrete;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Concrete;

namespace Training.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager=new ProductManager(new EfProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            dgvSource.DataSource = productManager.GetAll();

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DataSource = categoryManager.GetAll();

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            dgvSource.DataSource = productManager.GetByCategory((int)cmbCategories.SelectedValue);
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