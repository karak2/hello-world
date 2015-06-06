using System.ServiceModel;
using System.ServiceModel.Web;

namespace CarsBigDataService
{
    [ServiceContract]
    public interface IUserReviewSaveService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "savereview")]
        UserReviewSaveResult SaveReview(UserReview review);
    }

}
