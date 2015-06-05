using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;

namespace CarsBigDataService_UnitTest
{
    [TestClass]
    public class write_to_mongo_json
    {
        [TestMethod]
        public void from_string_to_mongo_json()
        {
            var toBeParsed =
                "{\"AverageConsumption\":1.1,\"Brand\":\"bmw\",\"Comfort\":10,\"DrivenKms\":1000,\"Garage\":9,\"KmsWhenBought\":100,\"Performance\":8,\"Relyability\":7,\"RunningCost\":6,\"TotalImpression\":5,\"Type\":\"x1\",\"Verdict\":4,\"YearOfManufacturing\":2,\"YearOfPurchase\":0}";
            var result = BsonDocument.Parse(toBeParsed);
            Assert.IsNotNull(result);
            Assert.AreEqual(14, result.ElementCount);
        }
    }
}
