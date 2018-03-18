using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_hello.Controllers
{
    public class ProductController : Controller
    {
        IRepository _Repository;

        public ProductController(IRepository repository)
        {
            _Repository = repository;
        }
        public IActionResult Index()
        {
            var products = _Repository.GetProducts();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = _Repository.GetProductById(id);
            return View(product);
        }
    }
}