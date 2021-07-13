using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwitterAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwitterAPI.Controllers
{
    [Route("/api/v1.0/[controller]")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        private ITwitterRepository repo;


        public TweetController()
        {
            repo = new TweetMock();
        }
       
        [HttpGet("/api/v1.0/[controller]/all")]
        public List<Tweet> All()
        {
            return repo.GetAllTweeets();
        }

        // GET api/<TweetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TweetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TweetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TweetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
