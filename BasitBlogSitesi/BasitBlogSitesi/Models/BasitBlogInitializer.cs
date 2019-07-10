using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasitBlogSitesi.Models
{
    public class BasitBlogInitializer:DropCreateDatabaseIfModelChanges<BasitBlogContext>
    {
        protected override void Seed(BasitBlogContext context)
        {

            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                new Category(){KategoriAdi="Asp.net MVC"},
                new Category(){KategoriAdi="Android"},
                new Category(){KategoriAdi="PHP"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();


            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){ Baslik="C# Değişkenler", Icerik=" C# da değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-10), Aciklama="Bu konumuzda C# da değişkenleri anlattık umarım faydalı olur", Onay=true, Resim="1.jpg", CategoryId=1, Anasayfa=true  

                },

                new Blog(){ Baslik="Asp.net Mvc Değişkenler", Icerik=" C# da değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-8), Aciklama="Bu konumuzda Asp.net MVC de değişkenleri anlattık umarım faydalı olur", Onay=true, Resim="2.jpg", CategoryId=2,Anasayfa=true

                },

                    new Blog(){ Baslik="Android Değişkenler", Icerik=" Android de değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-6), Aciklama="Bu konumuzda Android de değişkenleri anlattık umarım faydalı olur", Onay=true, Resim="3.jpg", CategoryId=3,Anasayfa=true

                },

                    new Blog(){ Baslik="PHP Değişkenler", Icerik=" PHP de değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-15), Aciklama="Bu konumuzda PHP de değişkenleri anlattık umarım faydalı olur", Onay=false, Resim="4.jpg", CategoryId=4,Anasayfa=true

                },

              new Blog(){ Baslik="C# Değişkenler", Icerik=" C# da değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-20), Aciklama="Bu konumuzda C# da değişkenleri anlattık umarım faydalı olur", Onay=true, Resim="1.jpg", CategoryId=1,Anasayfa=false

                },

              new Blog(){ Baslik="Asp.net Mvc Değişkenler", Icerik=" C# da değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-12), Aciklama="Bu konumuzda Asp.net MVC de değişkenleri anlattık umarım faydalı olur", Onay=true, Resim="2.jpg", CategoryId=2,Anasayfa=true

                },

               new Blog(){ Baslik="Android Değişkenler", Icerik=" Android de değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-18), Aciklama="Bu konumuzda Android de değişkenleri anlattık umarım faydalı olur", Onay=false, Resim="3.jpg", CategoryId=3,Anasayfa=false
               },

                new Blog(){ Baslik="PHP Değişkenler", Icerik=" PHP de değişkenler değişken türü değişken ismi eşittir değişken değeri şeklinde tanımlanır", EklenmeTarihi=DateTime.Now.AddDays(-4), Aciklama="Bu konumuzda PHP de değişkenleri anlattık umarım faydalı olur", Onay=true, Resim="4.jpg", CategoryId=4,Anasayfa=true

                },



            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}