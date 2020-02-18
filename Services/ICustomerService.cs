using NewTinyCRMApi.Model;
using NewTinyCRMApi.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTinyCRMApi.Services
{
    public interface ICustomerService
    {
        ApiResult<IQueryable<Customer>> Search(SearchCustomerOptions options);
        ApiResult<Customer> Create(CreateCustomerOptions options);
        ApiResult<Customer> GetCustomerById(int customerId);
        ApiResult<List<Customer>> GetCustomers(int howMany);
        ApiResult<Customer> Update(int id, CreateCustomerOptions options);
        public decimal TotalGross(int customerid);
    }
}
