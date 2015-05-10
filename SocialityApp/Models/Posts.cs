using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialityApp.Models
{
    public class Posts
    {
        public int Id { get; set; }
         [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        [StringLength(100,ErrorMessage="The {0} must be at least {2} character long",MinimumLength=5)]
        public string Title { get; set; }
        [Required]
        [StringLength(2000, ErrorMessage = "The {0} must be at least {2} character long", MinimumLength = 5)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-YY}")]
        public DateTime Time { get; set; }
        [ForeignKey("File")]
        public int FileId { get; set; }
        public virtual ICollection<SocialityApp.Models.File> File { get; set; }
       
    }
}