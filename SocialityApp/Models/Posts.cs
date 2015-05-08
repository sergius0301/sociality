using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SocialityApp.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        [StringLength(100,ErrorMessage="The {0} must be at least {2} character long",MinimumLength=5)]
        public string Title { get; set; }
        [Required]
        [StringLength(2000, ErrorMessage = "The {0} must be at least {2} character long", MinimumLength = 5)]
        public string Description { get; set; }
    }
}