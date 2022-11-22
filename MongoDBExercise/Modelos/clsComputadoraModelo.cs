using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBExercise.Models
{
    /// <summary>
    /// Modelo de los objetos que contendrá la base de datos.
    /// </summary>
    public class clsComputadoraModelo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; }
        [BsonElement("nombreComputadora")]
        public string sNombreComputadora { get; set; }
        [BsonElement("RAM")]
        public string sRAM { get; set; }
        [BsonElement("unidadAlmacenamiento")]
        public string sUnidadAlmacenamiento { get; set; }
        [BsonElement("tarjetaMadre")]
        public string sTarjetaMadre { get; set; }
        [BsonElement("GPU")]
        public string sGPU { get; set; }
        [BsonElement("CPU")]
        public string sCPU { get; set; }
        [BsonElement("fuentePoder")]
        public string sFuentePoder { get; set; }
        [BsonElement("maintenanceLog")]
        public List<string> lstMantenimiento { get; set; }
    }
}
