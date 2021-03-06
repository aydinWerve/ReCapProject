﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{Id = 1, BrandName = "BMW"},
                new Brand{Id = 2, BrandName = "Tofaş"},
                new Brand{Id = 3, BrandName = "Mercedes"}
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand DeleteToBrand = _brands.SingleOrDefault(b => b.Id == brand.Id);
            _brands.Remove(DeleteToBrand);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            Brand UpdateToBrand = _brands.SingleOrDefault(b => b.Id == brand.Id);
            UpdateToBrand.BrandName = brand.BrandName;
        }
    }
}
