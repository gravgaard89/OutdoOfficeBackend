using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace boom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorController : ControllerBase
    {
        [HttpGet]
        [Route("/api/Instructor/")]
        public List<Instructor> Get()
        {
            string text = System.IO.File.ReadAllText("/Users/larsgrav/Desktop/data/instructors.txt");
            var result = JsonConvert.DeserializeObject<List<Instructor>>(text);
            return result;
        }
    }
}
