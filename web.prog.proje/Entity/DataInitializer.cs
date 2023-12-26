using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web.prog.proje.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { Name = "yeni dogan bebek", Description = "yeni dogan bebek urunleri"},
                new Category() { Name = "0-6 ay bebek", Description = "6-9 ay bebek urunleri"},
                new Category() { Name = "9-12 ay bebek", Description = "9-12 ay bebek uurnleri"},
                new Category() { Name = "12-18 ay bebek", Description = "12-18 ay bebek urunleri"},
                new Category() { Name = "18-24 ay bebek", Description = "18-24 ay bebek urunleri"},

            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
               { 
                new Product() { Name = "yeni doğan bebek ", Description = "Açıklama 1", Price = 19.99m, Stock = 50, IsApproved = true, CategoryId = 1 , IsHome = true, Image = "1.1.jpg"},
                new Product() { Name = "Ürün 2", Description = "Açıklama 2", Price = 29.99m, Stock = 30, IsApproved = true, CategoryId = 1,  IsHome = true,Image = "1.2.jpg"},
                new Product() { Name = "Ürün 3", Description = "Açıklama 3", Price = 39.99m, Stock = 20, IsApproved = true, CategoryId = 1, IsHome = true, Image = "1.3.jpg" },
                new Product() { Name = "Ürün 4", Description = "Açıklama 4", Price = 49.99m, Stock = 10, IsApproved = true, CategoryId = 1, IsHome = true,Image = "1.4.jpg" },
                new Product() { Name = "Ürün 5", Description = "Açıklama 5", Price = 59.99m, Stock = 5, IsApproved = false, CategoryId = 1, IsHome = true,Image = "1.5.jpg" },

                new Product() { Name = "Ürün 6", Description = "Açıklama 6", Price = 69.99m, Stock = 15, IsApproved = true, CategoryId = 2, IsHome = true, Image = "0-6.1.jpg"},
                new Product() { Name = "Ürün 7", Description = "Açıklama 7", Price = 79.99m, Stock = 25, IsApproved = true, CategoryId = 2,IsHome = true,Image = "0-6.2.jpg" },
                new Product() { Name = "Ürün 8", Description = "Açıklama 8", Price = 89.99m, Stock = 35, IsApproved = true, CategoryId = 2,IsHome = true,Image = "0-6.3.jpg" },
                new Product() { Name = "Ürün 9", Description = "Açıklama 9", Price = 99.99m, Stock = 45, IsApproved = true, CategoryId = 2,IsHome = true,Image = "0-6.4.jpg" },
                new Product() { Name = "Ürün 10", Description = "Açıklama 10", Price = 109.99m, Stock = 55, IsApproved = false, CategoryId = 2,IsHome = true, Image = "0-6.5.jpg" },

                new Product() { Name = "Ürün 11", Description = "Açıklama 11", Price = 119.99m, Stock = 65, IsApproved = true, CategoryId = 3, IsHome = true,Image = "3.jpg"}, 
                new Product() { Name = "Ürün 12", Description = "Açıklama 12", Price = 129.99m, Stock = 75, IsApproved = true, CategoryId = 3,IsHome = true, Image = "3.jpg" },
                new Product() { Name = "Ürün 13", Description = "Açıklama 13", Price = 139.99m, Stock = 85, IsApproved = true, CategoryId = 3,IsHome = true, Image = "3.jpg" },
                new Product() { Name = "Ürün 14", Description = "Açıklama 14", Price = 149.99m, Stock = 95, IsApproved = true, CategoryId = 3,IsHome = true, Image = "3.jpg" },
                new Product() { Name = "Ürün 15", Description = "Açıklama 15", Price = 159.99m, Stock = 105, IsApproved = false, CategoryId = 3, IsHome = true, Image = "3.jpg" },

                new Product() { Name = "Ürün 16", Description = "Açıklama 16", Price = 169.99m, Stock = 115, IsApproved = true, CategoryId = 4,IsHome = true, Image = "4.jpg"},
                new Product() { Name = "Ürün 17", Description = "Açıklama 17", Price = 179.99m, Stock = 125, IsApproved = true, CategoryId = 4,IsHome = true,Image = "4.jpg" },
                new Product() { Name = "Ürün 18", Description = "Açıklama 18", Price = 189.99m, Stock = 135, IsApproved = true, CategoryId = 4,IsHome = true, Image = "4.jpg" },
                new Product() { Name = "Ürün 19", Description = "Açıklama 19", Price = 199.99m, Stock = 145, IsApproved = true, CategoryId = 4 ,IsHome = true, Image = "4.jpg"},
                new Product() { Name = "Ürün 20", Description = "Açıklama 20", Price = 209.99m, Stock = 155, IsApproved = false, CategoryId = 4,IsHome = true, Image = "4.jpg"},

                new Product() { Name = "Ürün 15", Description = "Açıklama 21", Price = 159.99m, Stock = 105, IsApproved = true, CategoryId = 5,IsHome = true , Image = "5.jpg"},
                new Product() { Name = "Ürün 16", Description = "Açıklama 22", Price = 169.99m, Stock = 115, IsApproved = true, CategoryId = 5,IsHome = true,Image = "5.jpg" },
                new Product() { Name = "Ürün 17", Description = "Açıklama 23", Price = 179.99m, Stock = 125, IsApproved = true, CategoryId = 5 ,IsHome = true, Image = "5.jpg"},
                new Product() { Name = "Ürün 18", Description = "Açıklama 24", Price = 189.99m, Stock = 135, IsApproved = true, CategoryId = 5,IsHome = true,Image = "5.jpg" },
                new Product() { Name = "Ürün 19", Description = "Açıklama 25", Price = 199.99m, Stock = 145, IsApproved = false, CategoryId = 5,IsHome = true,Image = "5.jpg" }

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            var Hakkimizda = new List<Hakkimizda>()
            {
                new Hakkimizda() { Link = "https://tr.pinterest.com/search/pins/?q=baby%20esthetics%20clothes%20baby&rs=typed"},
                new Hakkimizda() { Link = "https://tr.pinterest.com/pin/140806230285838/"},
                new Hakkimizda() { Link = "https://tr.pinterest.com/pin/211174976276712/"},
                new Hakkimizda() { Link = "https://tr.pinterest.com/pin/30680841205066980/"},

            };

            foreach (var Hakkimda in Hakkimizda)
            {
                context.Hakkimizda.Add(Hakkimda);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }

}