﻿using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web.Mvc;
using web.prog.proje.Entity;
using web.prog.proje.Models;

namespace web.prog.proje.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel() 
                {
                        Id = i.Id,
                        Name = i.Name.Length > 30 ? i.Name.Substring(0, 47) + "..." : i.Name,
                        Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "...":i.Description,
                        Price = i.Price,
                        Stock = i.Stock,
                        Image = i.Image,
                        CategoryId = i.CategoryId,

                }).ToList();
                
               

            return View(urunler);
        }
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id== id).FirstOrDefault());

        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                .Where(i =>  i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ,
                    CategoryId = i.CategoryId,

                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);

            }



            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());

        }

        public ActionResult Login()
        {  
            return View();
        }

      
    }

    
}