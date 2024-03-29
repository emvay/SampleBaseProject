﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Abstract;
using Training.Entities.Concrete;

namespace Training.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll() 
        {
            using (TrainingContext trainingContext=new TrainingContext())
            {
                return trainingContext.Products.ToList();
            }
        }

        public Product GetById(int id) 
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                return trainingContext.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }
        public List<Product> GetByCategoryID(int categoryId)
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                return trainingContext.Products.Where(p => p.CategoryID == categoryId).ToList();
            }
        }
        public void Add(Product product) 
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                trainingContext.Products.Add(product);
                trainingContext.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                trainingContext.Products.Update(product);
                trainingContext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                trainingContext.Products.Remove(product);
                trainingContext.SaveChanges();
            }
        }
    }
}
