using MongoDB.Bson;
using MongoDB.Driver;
using WebApplication2.Model;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.Extensions.Configuration;

namespace WebApplication2.Classes
{
    public class Connection 
    {
        private IMongoDatabase _database;
        public void Connect(IConfiguration connect)
        {
            var connectionString = connect.GetConnectionString("DefaultConnection");
            var dbclient = new MongoClient(connectionString);
            _database = dbclient.GetDatabase("Test");
        }

        public IMongoCollection<Employee> Employee()
        {
            Connect();
            return _database.GetCollection<Employee>("Books");
        }
    }
}
