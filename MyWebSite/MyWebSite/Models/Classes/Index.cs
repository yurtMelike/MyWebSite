using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models.Classes
{
    public class Index
    {
        [Key]
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Content { get; set; }
    }
}