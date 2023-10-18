﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Concrete;

namespace Training.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal=new ProductDal();
        public List<Product> GetAll() 
        {  
            return _productDal.GetAll();
        }
    }
}
