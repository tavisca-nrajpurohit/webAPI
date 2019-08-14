using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "[GET Method Usage] Use URL to pass a Parameter! Syntax: .../api/values/[paramters], " +
                "[POST Method] Use Syntax in body - year:[year]" };
        }
        /*
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            if (String.Equals(id, "Hello") || String.Equals(id, "hello"))
                return "Hi";
            else if (String.Equals(id, "Hi") || String.Equals(id, "hi"))
                return "Hello";
            else
                return "Have a Good Day Ahead!";
        }*/

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id % 100 == 0)
                id = id / 100;

            if (id%4 == 0)
                return "Leap Year";
            else
                return "Not a Leap Year!";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]JObject value)
        {
            Dictionary<string, string> data = value.ToObject<Dictionary<string,string>>();
            if (data.ContainsKey("name"))
            {
                string myName = data["name"];
                return $"Name passed into the API was : {myName}";
            }
            else
                return "Error";
            /*
             * string[] array = value.Split(':');
            int id = Int32.Parse(array[1]);

            if (id % 100 == 0)
                id = id / 100;

            if (id % 4 == 0)
                return $"Year {id} is a Leap Year";
            else
                return $"Year {id} is a not a Leap Year!";
                */
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
