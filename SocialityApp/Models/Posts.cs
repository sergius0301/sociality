using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialityApp.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}