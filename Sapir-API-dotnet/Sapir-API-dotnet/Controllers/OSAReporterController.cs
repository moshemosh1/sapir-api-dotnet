using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sapir_API_dotnet.Models;

namespace Sapir_API_dotnet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OSAReporterController : ControllerBase
    {
        [HttpGet("FullResult")]
        public IEnumerable<Person> GetFullResult()
        {
            string jsonData = System.IO.File.ReadAllText("./Jsons/tableMock.json");
            IEnumerable<Person> persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(jsonData);
            return persons;

        }

        [HttpGet("SingleResult")]
        public IEnumerable<Person> GetSingleResult()
        {
            string jsonData = System.IO.File.ReadAllText("./Jsons/tableMock.json");
            IEnumerable<Person> persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(jsonData);
            return persons;

        }
    }
}
