using MongoDB.Bson;
using System.IO;
using System.Runtime.Serialization.Json;

namespace CarsBigDataService
{
    public static class UserReviewAndBsonConverter
    {
        public static BsonDocument ToBsonDocument(UserReview review)
        {
            return _ToBsonDocument(_ToJsonString(review));
        }

        private static BsonDocument _ToBsonDocument(string json)
        {
            return BsonDocument.Parse(json);
        }
        
        private static string _ToJsonString(UserReview review)
        {
            var serialzer = new DataContractJsonSerializer(typeof(UserReview));
            using (var stream = new MemoryStream())
            {
                serialzer.WriteObject(stream, review);
                stream.Position = 0;
                using (var streamReader = new StreamReader(stream))
                {
                    var result = streamReader.ReadToEnd();
                    return result;        
                }
            }
        }

    }
}