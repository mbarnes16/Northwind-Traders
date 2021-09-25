using Microsoft.AspNetCore.Mvc;
using Northwind_Traders.Models;
using System.Linq;

namespace Northwind_Traders.Controllers
{
    public class ProductController : Controller
    {
        // this controller depends on the NorthwindRepository
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;
          //public IActionResult Index() => View(_bloggingContext.Blogs);
        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(b=>b.CategoryName));

        public IActionResult Index(int id) => View(_northwindContext.Products.Where(p=>p.CategoryId==id && !p.Discontinued));
    }
    
}