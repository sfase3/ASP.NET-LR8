using ASP.NET_LR8.Models;
using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    public ActionResult Index()
    {
        var products = GetSampleProducts();
        return View("./Views/Home/Index.cshtml", products);
    }

    private List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product { ID = 1, Name = "Iphone Xs", Price = 27m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Poco X3", Price = 12, CreatedDate = DateTime.Now.AddHours(-12) },
            new Product { ID = 3, Name = "Nokia 3310", Price = 3, CreatedDate = DateTime.Now.AddHours(27) }
        };
    }
}

