
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB;
using System.Configuration;
using Medical_Platform.Entity;

namespace Medical_Platform.Database
{
    public class Context
    {
        public IMongoDatabase database { get; }

        private IConfiguration configuration;

        public IMongoCollection<User> users { get; }
        public Context(IConfiguration configuration)
        {
            this.configuration = configuration;

            var client = new MongoClient(
                       configuration.GetValue<string>("DataBaseSettings:ConnectionString")
                   );

            database = client.GetDatabase(
               configuration.GetValue<string>("DataBaseSettings:DatabaseName")
           );

            users = database.GetCollection<User>("users");
        }

    }

}


