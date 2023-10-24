﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Entities.Concrete;

namespace Training.Business.Abstract
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
    }
}
