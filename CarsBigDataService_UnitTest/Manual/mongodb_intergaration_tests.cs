using CarsBigDataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;

namespace CarsBigDataService_UnitTest.Manual
{
    [TestClass]
    [Ignore]
    public class mongodb_intergaration_tests
    {
        [TestMethod]
        [TestCategory("Manual")]
        public void adding_new_item_to_the_reviews()
        {
            new UserReviewSaveService().SaveReview(new UserReview() { Brand = "BMW", Type = "X1"});
        }
    }
}
