using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;




namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        //private readonly IRepositoryManager _manager;
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }



        /* public IEnumerable <Product> Index()
         {
            return _context.Products;  
         }*/

        public IActionResult Index()
        {
            var model = _manager.ProductService.GetAllProducts(false);
            return View(model);
        }
        public IActionResult Get([FromRouteAttribute(Name="id")]int id)
        {
            //Product product = _manager.Products.First(p => p.ProductId.Equals(id));
            var model=_manager.ProductService.GetOneProduct(id,false);

            return View(model);
        }



    }

}