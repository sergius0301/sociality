using SocialityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SocialityApp.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET api/values
        public dynamic Get()
        {
            //return new string[] { "value1", "value2" };
            return db.Posts.Select(i => new { i.Id, i.User.Email, i.Title, i.Description });
  
        }

        // GET api/values/5
        public dynamic Get(int id)
        {
          
            return db.Posts.Find(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
