using HistoryOfChristianity.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HistoryOfChristianity.Web.Controllers;
public class ProductController : Controller
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService) => _productService = productService;
    
    public IActionResult Index() => View(_productService.GetAllProducts());
}
