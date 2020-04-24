using MongoDB.Driver;
using ProIndex.Models;

namespace ProIndex
{
    public class GetData
    {
        IMongoCollection<AllIndex> CollectionAllIndex{ get; set; }
        IMongoCollection<SurveyAndCompany> CollectionSurveyAndCompany { get; set; }
        public GetData()
        {
            var client = new MongoClient("mongodb://firstclass:Th35F1rstCla55@mongoquickx4h3q4klpbxtq-vm0.southeastasia.cloudapp.azure.com/wdata");
            var database = client.GetDatabase("wdata");
            CollectionAllIndex = database.GetCollection<AllIndex>("AllIndex");
            CollectionSurveyAndCompany = database.GetCollection<SurveyAndCompany>("SurveyAndCompany");
        }
    }
}