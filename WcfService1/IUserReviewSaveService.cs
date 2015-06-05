using System.ServiceModel;

namespace CarsBigDataService
{
    [ServiceContract]
    public interface IUserReviewSaveService
    {
        [OperationContract]
        void SaveReview(UserReview review);
    }

}
