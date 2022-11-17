using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBExercise.Models
{
    public class ComputerModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("computerName")]
        public string ComputerName { get; set; }
        [BsonElement("RAM")]
        public string RAM { get; set; }
        [BsonElement("storageUnit")]
        public string StorageUnit { get; set; }
        [BsonElement("motherBoard")]
        public string MotherBoard { get; set; }
        [BsonElement("GPU")]
        public string GPU { get; set; }
        [BsonElement("CPU")]
        public string CPU { get; set; }
        [BsonElement("powerSource")]
        public string PowerSource { get; set; }
        [BsonElement("maintenanceLog")]
        public List<string> MaintenanceLog { get; set; }
    }
}
