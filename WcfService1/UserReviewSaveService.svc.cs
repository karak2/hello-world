using System;

namespace CarsBigDataService
{
    public class UserReviewSaveService : IUserReviewSaveService
    {

        public UserReviewSaveResult SaveReview(UserReview review)
        {
            try
            {
                MongoHelper.InsertUserReview(UserReviewAndBsonConverter.ToBsonDocument(review)); 
            }
            catch (Exception exception)
            {
                return new UserReviewSaveResult() {ErrorMessage = exception.ToString()};
            }
            return new UserReviewSaveResult();
        }
    }
}
