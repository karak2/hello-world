using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CarsBigDataService
{
    public class MongoHelper
    {
        private readonly static IMongoCollection<BsonDocument> userReviewCollection;
        


        static MongoHelper()
        {
            const string adminConnectionString = "mongodb://Admin:aGd5679812@ds049157.mongolab.com:49157/firstmongolabforuserreviews";
            MongoClient MongoClient = new MongoClient(adminConnectionString);
            var db = MongoClient.GetDatabase("firstmongolabforuserreviews");
            userReviewCollection = db.GetCollection<BsonDocument>("UserReview");
        }

        public static void InsertUserReview(BsonDocument review)
        {
            Task insertTask = userReviewCollection.InsertOneAsync(review);
            insertTask.Wait();
        }

    }
}