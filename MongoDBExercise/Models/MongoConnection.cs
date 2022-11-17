using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBExercise.Models
{
    public static class MongoConnection
    {
        public static IMongoCollection<ComputerModel> GetCollection()
        {
            MongoClient Client = new MongoClient("mongodb://localhost:27017");
            var Database = Client.GetDatabase("Computer");
            return Database.GetCollection<ComputerModel>("Computers");
        }
    }
}