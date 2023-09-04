using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Api.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*",headers: "*",methods: "*")]
    public class feedbackController : ApiController
    {
        // GET: api/feedback
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(DB.listFeedBacks);
        }

        // GET: api/feedback/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/feedback
        [HttpPost]
        public IHttpActionResult Post([FromBody]FeedBack feedBack)
        {
            DB.listFeedBacks.Add(feedBack);
            return Ok(DB.listFeedBacks);
        }

        // PUT: api/feedback
        [HttpPut]
        public void Put([FromBody] FeedBack feedBack)
        {
            foreach(var item in DB.listFeedBacks)
            {
                if (item.feedBack.Equals(feedBack.feedBack))
                    item.numberLike = feedBack.numberLike;

            }
          
        }

        // DELETE: api/feedback/5
        public void Delete(int id)
        {
        }
    }
}
