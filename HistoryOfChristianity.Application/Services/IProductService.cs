using HistoryOfChristianity.Application.DTOs;

namespace HistoryOfChristianity.Application.Services;
public interface IProductService
{
    public IEnumerable<ProductDto> GetAllProducts();
}
