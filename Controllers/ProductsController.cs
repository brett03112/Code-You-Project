using Microsoft.AspNetCore.Mvc;
using My_Project.Models;

namespace My_Project.Controllers;

public class ProductsController : Controller
{
    // temp in memory list of products
    private static List<Product> _products = new List<Product>();
    
    /// <summary>
    /// The index action shows the list of products
    /// </summary>
    /// <returns>View with the list of products</returns>
    public IActionResult Index()
    {
        return View(_products);
    }
    
    /// <summary>
    /// The Create action shows the form to create a new product
    /// </summary>
    /// <returns>View with the form to create a new product</returns>
    public IActionResult Create()
    {
        return View();
    }
    
    /// <summary>
    /// The Create action posts a new product to the database
    /// </summary>
    /// <param name="product">The product to be created</param>
    /// <returns>Redirects to the Index action if the model is valid, else shows the form again</returns>
    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _products.Add(product);
            return RedirectToAction("Index");
        }
        
        return View(product);
    }
}