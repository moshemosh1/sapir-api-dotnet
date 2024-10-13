using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Sapir_API_dotnet.Models
{
    [BsonIgnoreExtraElements]
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("firstName")]
        public string? FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }
        [BsonElement("age")]
        public int? Age { get; set; }
    }
}