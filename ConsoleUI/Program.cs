using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //CarTest();
            //CustomerTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine("UserId giriniz");
            var userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("CompanyName giriniz");
            var companyName = Console.ReadLine();

            Customer customer = new Customer();
            customer.UserId = userId;
            customer.CompanyName = companyName;

            var result = customerManager.Add(customer);

            if (result.Success)
            {
                Console.WriteLine("başarılı bir şekilde eklendi");
            }
            else
            {
                Console.WriteLine("eklenemedi");
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetailDTOs();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " --> " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
