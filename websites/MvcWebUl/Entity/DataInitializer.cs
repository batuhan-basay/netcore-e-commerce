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


            List<Product> urunler = new List<Product>()
            {
                new Product(){ Name = "Iphone 6", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 6000, Stock = 100, IsApproved = true , CategoryId = 1, IsHome= true, Image = "1.jpg" },
                new Product(){ Name = "Laptop", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 8000, Stock = 200, IsApproved = true , CategoryId = 2, IsHome= true, Image = "2.jpg" },
                new Product(){ Name = "Samsung s8", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 4000, Stock = 10, IsApproved = true , CategoryId = 1, IsHome= true, Image = "2.jpg" },
                new Product(){ Name = "Lenova pc", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 3000, Stock = 120, IsApproved = true , CategoryId = 3, IsHome= true, Image = "3.jpg" },
                new Product(){ Name = "asus pc", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 3000, Stock = 120, IsApproved = true , CategoryId = 3, IsHome= true, Image = "2.jpg" },
                new Product(){ Name = "apple pc", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 3000, Stock = 120, IsApproved = true , CategoryId = 3, IsHome= true, Image = "3.jpg" },
                new Product(){ Name = "monster pc", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 3000, Stock = 120, IsApproved = true , CategoryId = 3, IsHome= true, Image = "3.jpg" },
                new Product(){ Name = "Kamera", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." , Price = 6000, Stock = 110, IsApproved = false , CategoryId = 2, IsHome= true, Image = "4.jpg" },

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();


        }

    }
}