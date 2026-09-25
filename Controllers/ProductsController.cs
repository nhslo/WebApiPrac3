using Microsoft.AspNetCore.Mvc;
using WebApiPrac3.Models;
using WebApiPrac3.Services;

namespace WebApiPrac3.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(
        IProductService service,
        ILogger<ProductsController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        _logger.LogInformation("Getting all products");
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _service.GetById(id);

        if (product is null)
        {
            _logger.LogWarning("Product with ID {ProductId} was not found", id);
            return NotFound();
        }

        _logger.LogInformation("Product with ID {ProductId} was found", id);
        return Ok(product);
    }
}
