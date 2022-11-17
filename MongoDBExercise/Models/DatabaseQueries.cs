using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBExercise.Models
{
    public static class DatabaseQueries
    { 
        public static List<ComputerModel> GetAllValues()
        {
            var Computers = MongoConnection.GetCollection();
            List<ComputerModel> ComputersList = Computers.Find(d => true).ToList();
            return ComputersList;
        }

        public static void InsertOneValue(ComputerModel Computer)
        {
            var Computers = MongoConnection.GetCollection();
            Computers.InsertOne(Computer);
        }

        public static void UpdateOneValue(ComputerModel Computer)
        {
            var Computers = MongoConnection.GetCollection();
            Computers.ReplaceOne(d => d.ComputerName == Computer.ComputerName, Computer);
        }

        public static void DeleteOneValue(ComputerModel Computer)
        {
            var Computers = MongoConnection.GetCollection();
            Computers.DeleteOne(d => d.ComputerName == Computer.ComputerName);
        }

        public static ComputerModel FindOneComputer(string ComputerName)
        {
            try
            {
                var Computers = MongoConnection.GetCollection();
                ComputerModel computer = Computers.Find(d => d.ComputerName == ComputerName).First();
                return computer;
            }catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
