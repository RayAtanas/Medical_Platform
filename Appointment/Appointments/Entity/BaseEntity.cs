using MongoDB.Bson.Serialization.Attributes;

namespace Appointments.Entity
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public DateTime deletedAt { get; set; }

        public bool isdeleted;

        public bool isHospital;
    }
}
