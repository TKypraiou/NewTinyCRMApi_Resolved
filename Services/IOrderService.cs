using NewTinyCRMApi.Model;
using NewTinyCRMApi.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTinyCRMApi.Services
{
    public interface IOrderService
    {
        public ApiResult<Order> CreateOrder(CreateOrderOptions options);
        public ApiResult<IQueryable<Order>> SearchOrder(SearchOrderOptions options);
    }
}
