namespace CarsBigDataService
{
    public class UserReviewSaveService : IUserReviewSaveService
    {

        public void SaveReview(UserReview review)
        {
            MongoHelper.InsertUserReview(UserReviewAndBsonConverter.ToBsonDocument(review)); 
        }
    }
}
