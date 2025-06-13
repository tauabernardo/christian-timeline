using HistoryOfChristianity.Application.DTOs;
using HistoryOfChristianity.Domain.Interfaces;

namespace HistoryOfChristianity.Application.Services;
public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository) => _repository = repository;
    
    public IEnumerable<ProductDto> GetAllProducts() => 
        _repository.GetAll().Select(p => new ProductDto {
            Id = p.Id,
            Name = p.Name,
            FormattedPrice = p.Price.ToString("C")
        });   
}
