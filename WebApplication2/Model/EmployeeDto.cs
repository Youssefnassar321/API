using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Model
{
    public class EmployeeDto
    {
        public string id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public int salary { get; set; }
    }
}
