using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Features.Products.Rules
{
    public class ProductBusinessRules
    {
        private readonly IProductRepository _productRepository;

        public ProductBusinessRules(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task ProductNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Product> result = await _productRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("Product name exists.");
        }

        public void ProductSouldExistWhenRequested(Product product)
        {
            if (product == null) throw new BusinessException("Requested product does not exist.");
        }
    }
}
