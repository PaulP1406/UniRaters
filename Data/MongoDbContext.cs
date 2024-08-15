using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using UniRaters.Models;

namespace UniRaters.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            _database = client.GetDatabase("UniRatersDb");
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
        public IMongoCollection<Course> Courses => _database.GetCollection<Course>("Courses");
        public IMongoCollection<Professor> Professors => _database.GetCollection<Professor>("Professors");
        public IMongoCollection<Review> Reviews => _database.GetCollection<Review>("Reviews");
    }
}
