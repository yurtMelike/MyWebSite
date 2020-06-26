
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyWebSite.Models.Classes
{
    public class Context : DbContext
    {
        DbSet<About> Abouts { get; set; }
        DbSet<Address> Adresses { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Blog> Blogs { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Contact> Contacts { get; set; }
    }
}