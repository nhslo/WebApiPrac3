using WebApiPrac3.Models;

namespace WebApiPrac3.Services;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product? GetById(int id);
}
