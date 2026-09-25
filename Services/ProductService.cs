using WebApiPrac3.Models;

namespace WebApiPrac3.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 350000 },
        new Product { Id = 2, Name = "Mouse", Price = 12000 },
        new Product { Id = 3, Name = "Keyboard", Price = 25000 }
    };

    public IEnumerable<Product> GetAll() => _products;

    public Product? GetById(int id) => _products.FirstOrDefault(product => product.Id == id);
}
