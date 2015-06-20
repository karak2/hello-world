using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace CarsBigDataService
{
    public class UserReviewSaveService : IUserReviewSaveService
    {

        public UserReviewSaveResult SaveReview(UserReview review)
        {
            try
            {
                review.IpAddress = _GetIp();
                MongoHelper.InsertUserReview(UserReviewAndBsonConverter.ToBsonDocument(review)); 
            }
            catch (Exception exception)
            {
                return new UserReviewSaveResult() {ErrorMessage = exception.ToString()};
            }
            return new UserReviewSaveResult();
        }

        private string _GetIp()
        {
            try
            {
                OperationContext context = OperationContext.Current;
                MessageProperties prop = context.IncomingMessageProperties;
                RemoteEndpointMessageProperty endpoint =
                    prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
                string ip = endpoint.Address;
                return ip;
            }
            catch (Exception exception)
            {
                return exception.ToString();
            }
        }
    }
}
