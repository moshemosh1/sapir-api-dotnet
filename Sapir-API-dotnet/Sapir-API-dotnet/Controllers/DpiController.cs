using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sapir_API_dotnet.Models;
using Sapir_API_dotnet.Services;
using System;
using System.IO;
using System.Text;

namespace Sapir_API_dotnet.Controllers
{
    
    [Route("[controller]")]
    public class DpiController : ControllerBase
    {

        private readonly IPersonService _personService;

        public DpiController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("GetDpiData")]
        public ActionResult<List<Person>> GetDpiData()
        {
            try
            {

                return _personService.GetAllPersons();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            //string jsonData = System.IO.File.ReadAllText("./Jsons/tableMock.json");
            //IEnumerable<Person> persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(jsonData);
            //return persons;

        }
    }
}
