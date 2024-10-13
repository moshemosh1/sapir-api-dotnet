namespace Sapir_API_dotnet.Models
{
    public class MongoDataBaseSettings : IMongoDataBaseSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string CollectionName { get; set; } = string.Empty;
        public string DataBase { get; set; } = string.Empty;
    }
}
