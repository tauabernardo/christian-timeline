using HistoryOfChristianity.Domain.Interfaces;
using HistoryOfChristianity.Domain.Entities;
using HistoryOfChristianity.Infrastructure.Data;

namespace HistoryOfChristianity.Infrastructure.Repositories;
public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context) => _context = context;
    
    public IEnumerable<Product> GetAll() => _context.Products.ToList();
}
