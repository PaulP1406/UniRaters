using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UniRaters.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("university")]
        public string University { get; set; }
    }
}
