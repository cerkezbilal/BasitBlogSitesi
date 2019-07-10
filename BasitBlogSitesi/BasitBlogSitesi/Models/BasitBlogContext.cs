using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasitBlogSitesi.Models
{
    public class BasitBlogContext:DbContext
    {

        public BasitBlogContext()
        {
            Database.SetInitializer(new BasitBlogInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }

    }
}