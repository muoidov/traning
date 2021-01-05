using Abp.Application.Services;
using muoi.Product.Dtos;

namespace muoi.Application.Product
{
    public interface IProductService: IAsyncCrudAppService<ProductDto>
    {
        

    }
}
