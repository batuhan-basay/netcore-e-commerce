using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebUl.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                 new Category(){ Name = "Telefon", Description = "Telefon urunleri"},
                new Category(){ Name = "Bilgisayar", Description = "Pc urunleri"},
                new Category(){ Name = "Kamera", Description = "kameraurunleri"},
                new Category(){ Name = "Elektronik", Description = "elektronik urunleri"},
                new Category(){ Name = "Beyaz Eşya", Description = "Beyaz Eşya urunleri"}
              
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();


            var urunler = new List<Product>()
            {
                new Product(){ Name = "Iphone 6", Description = "iyi" , Price = 6000, Stock = 100, IsApproved = true ,Catergory = 1 },
                new Product(){ Name = "Laptop", Description = "iyi" , Price = 8000, Stock = 200, IsApproved = true ,Catergory = 2 },
                new Product(){ Name = "Samsung s8", Description = "iyi" , Price = 4000, Stock = 10, IsApproved = false ,Catergory = 2 },
                new Product(){ Name = "Lenova pc", Description = "iyi" , Price = 3000, Stock = 120, IsApproved = true ,Catergory = 3 },
                new Product(){ Name = "Kamera", Description = "iyi" , Price = 6000, Stock = 110, IsApproved = false ,Catergory = 1 },

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();


        }

    }
}