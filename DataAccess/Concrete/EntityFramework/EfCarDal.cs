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
                             join b in context.Brands on cr.BrandId equals b.BrandId
                             join c in context.Colors on cr.ColorId equals c.ColorId
                             select new CarDetailDTO { CarId = cr.CarId, BrandName = b.BrandName, ColorName = c.ColorName, DailyPrice = cr.DailyPrice };
                return result.ToList();
            }
        }
    }
}