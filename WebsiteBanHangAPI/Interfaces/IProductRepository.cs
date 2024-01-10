using WebsiteBanHangAPI.DTOs;
using WebsiteBanHangAPI.Entities;
using WebsiteBanHangAPI.Helper;

namespace WebsiteBanHangAPI.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
