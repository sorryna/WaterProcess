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
        IMongoCollection<River> CollectionRiver{ get; set; }
        IMongoCollection<River> CollectionRiverIndex{ get; set; }
        public GetData()
        {
            var client = new MongoClient("mongodb://firstclass:Th35F1rstCla55@mongoquickx4h3q4klpbxtq-vm0.southeastasia.cloudapp.azure.com/wdata");
            var database = client.GetDatabase("wdata");
            Collection92Data = database.GetCollection<SurveyAndCompany>("92Data");
            CollectionAllIndex = database.GetCollection<AllIndex>("AllIndex");
            CollectionAllPoint = database.GetCollection<AllIndex>("AllPoint");
            CollectionRiver = database.GetCollection<River>("river2");
            CollectionRiverIndex = database.GetCollection<River>("riverIndex");
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

        public List<River> GetDataRiver(){
            return CollectionRiver.Find(it => true).ToList();
        }

        public AllIndex FindDataForRiver(string item){
            return CollectionAllIndex.Find(it => it._id == item).FirstOrDefault();
        }

        public void InsertRiverToDB(River item){
            CollectionRiverIndex.InsertOne(item);
        }
    }
}