using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<CustomerDetailDTO>> GetCustomerDetailDTOs();
    }
}
