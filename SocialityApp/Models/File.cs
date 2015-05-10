using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialityApp.Models
{
    public class File
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int PostsId { get; set; }
        public virtual Posts Post { get; set; }
       
    }
}