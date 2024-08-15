using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace UniRaters.Models
{
    public class Review
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("courseId")]
        public string CourseId { get; set; }

        [BsonElement("professorId")]
        public string ProfessorId { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("grade")]
        public string Grade { get; set; }

        [BsonElement("reviewText")]
        public string ReviewText { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }
    }
}
