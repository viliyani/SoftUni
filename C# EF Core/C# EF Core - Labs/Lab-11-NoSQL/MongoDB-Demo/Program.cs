using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace MongoDbDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MongoClient client = new MongoClient(
                "mongodb://127.0.0.1:27017"
            );

            var database = client.GetDatabase("test");

            var collection = database.GetCollection<BsonDocument>("softuniArticles");

            // Task - Print All Article Names
            List<BsonDocument> allArticles = collection.Find(new BsonDocument { }).ToList();

            foreach (var article in allArticles)
            {
                string name = article.GetElement("name").Value.AsString;
                Console.WriteLine(name);
            }

            // Task - Create new article
            collection.InsertOne(new BsonDocument
            {
                {"author", "Steve Jobs"},
                {"date", "05-05-2005"},
                {"name", "The story of Apple"},
                {"rating", "60"},
            });

            // Task - Update ratings
            foreach (var article in allArticles)
            {
                int newRating = int.Parse(article.GetElement("rating").Value.AsString) + 10;

                var filterQuery = Builders<BsonDocument>.Filter.Eq("_id", article.GetElement("_id").Value);

                var updateQuery = Builders<BsonDocument>.Update.Set("rating", newRating.ToString());

                collection.UpdateOne(filterQuery, updateQuery);

                Console.WriteLine(article.ToJson());
            }

            // Task - Delete articles which are with rating less than 50
            var filterQueryForDelete = Builders<BsonDocument>.Filter.Lt("rating", 50);
            collection.DeleteMany(filterQueryForDelete);
        }
    }
}
