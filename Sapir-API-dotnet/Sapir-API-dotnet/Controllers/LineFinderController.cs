using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sapir_API_dotnet.Models;

namespace Sapir_API_dotnet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LineFinderController : ControllerBase
    {

        [HttpGet("Potential")]
        public IEnumerable<Person> GetPotential()
        {
            string jsonData = System.IO.File.ReadAllText("./Jsons/tableMock.json");
            IEnumerable<Person> persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(jsonData);
            return persons;

        }

        [HttpGet("Processed")]
        public IEnumerable<Person> GetProcessed()
        {
            string jsonData = System.IO.File.ReadAllText("./Jsons/tableMock.json");
            IEnumerable<Person> persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(jsonData);
            return persons;

        }
    }
}
