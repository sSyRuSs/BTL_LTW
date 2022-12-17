using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        CompanyDBContext db =new CompanyDBContext();
        // GET: Product
        [MyAuthenFilter]
        public ActionResult Index()
        {
            List<Product> pro = db.products.ToList();
            return View(pro);
        }
        public ActionResult Details(int id) 
        {
            Product products = db.products.Where(t => t.ProductID == id).FirstOrDefault();
            
            return View(products);
        }
    }
}