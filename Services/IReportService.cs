using NewTinyCRMApi.Model;
using NewTinyCRMApi.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTinyCRMApi.Services
{
    interface IReportService
    {
        public List<Customer> TopTenCustomersByGross();
        public ApiResult<int> OrdersInEachStatus(SearchOrderOptions option);
    }
}
