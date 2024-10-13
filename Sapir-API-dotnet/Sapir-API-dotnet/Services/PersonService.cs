using Sapir_API_dotnet.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Sapir_API_dotnet.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMongoCollection<Person> _persons;

        public PersonService(IMongoDataBaseSettings settings,IMongoClient mongoClient)
        {
            var db = mongoClient.GetDatabase(settings.DataBase);
            _persons = db.GetCollection<Person>(settings.CollectionName);
        }
        public Person CreatePerson(Person person)
        {
            _persons.InsertOne(person);
            return person;
        }

        public void DeletePerson(string id)
        {
            _persons.DeleteOne(person => person.Id == id);
        }

        public List<Person> GetAllPersons()
        {
            return _persons.Find(person => true).ToList();
        }

        public Person GetPersonById(string id)
        {

            return _persons.Find(person => person.Id == id).FirstOrDefault();
        }

        public void UpdatePerson(Person person)
        {
            _persons.ReplaceOne(personToUpdate => personToUpdate.Id == person.Id, person);
        }
    }
}
