using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBExercise.Models
{
    /// <summary>
    /// Conexion a la base de datos.
    /// </summary>
    public static class clsConexionMongo
    {
        /// <summary>
        /// Conecta con la base de datos y obtiene la coleccion que contiene.
        /// </summary>
        /// <returns>Coleccion de computadoras.</returns>
        public static IMongoCollection<clsComputadoraModelo> ObtenerColeccion()
        {
            MongoClient oClient = new MongoClient("mongodb://localhost:27017");
            var Database = oClient.GetDatabase("Computadora");
            return Database.GetCollection<clsComputadoraModelo>("Computadoras");
        }
    }
}