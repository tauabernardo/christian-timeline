namespace HistoryOfChristianity.Application.Services;
public interface IProductService
{
    IEnumerable<ProductDto> GetAllProducts();
}
