﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Entities.Concrete;

namespace Training.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        public List<T> GetAll();

        public T GetById(int id);
        public void Add(T entity);
        public void Update(T entity);

        public void Delete(T entity);
    }
}
