namespace Sapir_API_dotnet.Models
{
    public interface IMongoDataBaseSettings
    {
        public string ConnectionString { get; set; }
        public string CollectionName { get; set; }
        public string DataBase { get; set; }
    }
}
