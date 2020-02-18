using NewTinyCRMApi.Model;
using NewTinyCRMApi.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTinyCRMApi.Services
{
    public interface IProductService
    {
        public ApiResult<Product> AddProduct(AddProductOptions options);
        bool UpdateProduct(Guid productId, UpdateProductOptions options);
        public ApiResult<Product> GetProductById(Guid id);
        public IQueryable<Product> SearchProduct(SearchProductOptions options);
        public int SumOfStocks();
    }
}
