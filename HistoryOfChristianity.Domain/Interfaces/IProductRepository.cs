using HistoryOfChristianity.Domain.Entities;

namespace HistoryOfChristianity.Domain.Interfaces;
public interface IProductRepository
{
    IEnumerable<Product> GetAll();
}
