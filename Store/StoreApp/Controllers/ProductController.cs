using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Repositories;
using Repositories.Contracts;




namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }



        /* public IEnumerable <Product> Index()
         {
            return _context.Products;  
         }*/

        public IActionResult Index()
        {
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }
        public IActionResult Get(int id)
        {
            //Product product = _context.Products.First(p => p.ProductId.Equals(id));

            throw new NotImplementedException();
        }



    }

}