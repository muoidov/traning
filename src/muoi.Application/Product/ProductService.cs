using Abp.Application.Services;
using Abp.Domain.Repositories;
using muoi.EntityFrameworkCore;
using muoi.Product.Dtos;
using System.Threading.Tasks;

namespace muoi.Application.Product
{
    public class ProductService : AsyncCrudAppService<muoi.Core.Data.Product, ProductDto>, IProductService
    {
        private muoiDbContext _muoiDbContext;
        public ProductService(IRepository<muoi.Core.Data.Product> repository)
        : base(repository)
        {

        }
        public override Task<ProductDto> CreateAsync(ProductDto input)
        {

            return base.CreateAsync(input);
        }


    }
}
