using Microsoft.AspNetCore.Mvc.Infrastructure;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Catelog.API.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        [Required]
        public string Name { get; set; }

        [BsonElement("category")]
        public string Category { get; set; }

        [BsonElement("price")]
        [Required]
        public double Price { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
