using System;
using System.IO;
using System.Runtime.Serialization.Json;
using CarsBigDataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarsBigDataService_UnitTest
{
    [TestClass]
    public class json_serialization
    {
        [TestMethod]
        public void user_review_to_json_and_back()
        {
            var review = new UserReview();
            review.Brand = "bmw";
            review.Type = "x1";
            review.AverageConsumption = 1.1;
            review.Comfort = 10;
            review.DrivenKms = 1000;
            review.Garage= 9;
            review.KmsWhenBought= 100;
            review.Performance= 8;
            review.Relyability= 7;
            review.RunningCost = 6;
            review.TotalImpression= 5;
            review.Verdict= 4;
            review.YearOfManufacturing = 3;
            review.YearOfManufacturing = 2;
            review.ServiceReceivedDateTime = DateTime.UtcNow;

            var serialzer = new DataContractJsonSerializer(typeof (UserReview));
            MemoryStream stream = new MemoryStream();
            serialzer.WriteObject(stream, review);
            stream.Position = 0;
            var result = new StreamReader(stream).ReadToEnd();
            Assert.IsNotNull(result);

            stream.Position = 0;
            UserReview deserdObject = serialzer.ReadObject(stream) as UserReview;
            Assert.IsTrue(deserdObject.Equals(review)); // semantical equals
            Assert.IsFalse(deserdObject == review);     // but not reference equals
        }
    }
}
