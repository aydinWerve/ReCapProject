using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetailDTOs()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cr in context.Cars
                             join b in context.Brands on cr.BrandId equals b.Id
                             join c in context.Colors on cr.ColorId equals c.Id
                             select new CarDetailDTO { BrandName = b.BrandName, ColorName = c.ColorName, DailyPrice = cr.DailyPrice };
                return result.ToList();
            }
        }
    }
}