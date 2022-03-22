using MvcWebUl.Entity;
using MvcWebUl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUl.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();


        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products
                .Where(i => i.IsHome == true && i.IsApproved == true)
                .Select(i=> new ProductModel() { 
                
                    Id=i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 50) + "..." : i.Name,
                    Description = i.Description.Length>50?i.Description.Substring(0,50)+"...":i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                    
            
                }).ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                .Where(i => i.IsApproved == true)
                .Select(i => new ProductModel()
                {

                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 50) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 50) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "1.jpg",
                    CategoryId = i.CategoryId


                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i. CategoryId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}