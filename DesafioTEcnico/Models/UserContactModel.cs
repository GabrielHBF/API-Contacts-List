﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DesafioTEcnico.Models
{
    public class UserContactModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime BirthDate {  get; set; }
        public List<string>? Address { get; set; }

    }
}
