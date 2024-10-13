using Sapir_API_dotnet.Models;

namespace Sapir_API_dotnet.Services
{
    public interface IPersonService
    {
        List<Person> GetAllPersons();
        Person GetPersonById(string id);
        Person CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(string id);

    }
}
