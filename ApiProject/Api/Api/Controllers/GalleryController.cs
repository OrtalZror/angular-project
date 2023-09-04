using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GalleryController : ApiController
    {
        // GET: api/Gallery
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(DB.ListGalleries);
        }

        // GET: api/Gallery/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Gallery
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Gallery/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Gallery/5
        public void Delete(int id)
        {
        }
    }
}
