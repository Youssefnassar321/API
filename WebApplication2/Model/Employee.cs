using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Model
{
    public class Employee
    {
        [BsonId]
        public ObjectId id { get; set; }

        [BsonIgnore]
        public string IdString => id.ToString();

        [Required]
        [MinLength(3)]
        public string name { get; set; }

        [Required]
        [Range(20, 50)]
        public int age { get; set; }

        [Required]
        [Range(1000, 20000)]
        public int salary { get; set; }
    }
}
