using MongoDB.Driver;
using ProIndex.Models;
using System.Collections.Generic;

namespace ProIndex
{
    public class GetData
    {
        IMongoCollection<SurveyAndCompany> Collection92Data { get; set; }
        IMongoCollection<AllIndex> CollectionAllIndex { get; set; }
        IMongoCollection<AllIndex> CollectionAllPoint{ get; set; }
        public GetData()
        {
            var client = new MongoClient("mongodb://firstclass:Th35F1rstCla55@mongoquickx4h3q4klpbxtq-vm0.southeastasia.cloudapp.azure.com/wdata");
            var database = client.GetDatabase("wdata");
            Collection92Data = database.GetCollection<SurveyAndCompany>("92Data");
            CollectionAllIndex = database.GetCollection<AllIndex>("AllIndex");
            CollectionAllPoint = database.GetCollection<AllIndex>("AllPoint");
        }

        public List<SurveyAndCompany> Get92Data()
        {
            var result = Collection92Data.Find(it => true).ToList();
            return result;
        }

        public void InsertIndexToDB(AllIndex item)
        {
            CollectionAllIndex.InsertOne(item);
        }

        public void InsertPointToDB(AllIndex item)
        {
            CollectionAllPoint.InsertOne(item);
        }
    }
}