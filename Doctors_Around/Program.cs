using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doctors_Around.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace Doctors_Around
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("DoctorsAround");
            //db.InsertRecord("Users",new Core.User() {Full_Adress="Random" });
            
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<User>(string table, User record)
        {
            var collection = db.GetCollection<User>(table);
            collection.InsertOne(record);
        }
        public void RemoveRecord(string table,Guid id)
        {
            var collection = db.GetCollection<User>(table);

        }
    }
}
