﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCareMangoDbProject.DataAccess.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public string InstructorName { get; set; }
    }
}
