using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TwitterAPI.Models
{
    public class TweetMock : ITwitterRepository
    {
        private readonly IMongoCollection<Tweet> _Tweet;
        private List<Tweet> alltweets;
        private Tweet tweets;
        
        public TweetMock()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://tweetcreator:tweetcreatorr@cluster0.ibube.mongodb.net/tweet?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("tweet");
            _Tweet = database.GetCollection<Tweet>("tweet");
            alltweets = new List<Tweet>();
            alltweets.Add(new Tweet() { TweetID = 1,UserID = "1", Tweethandle = "oyeoye", TweetMessage = "oyeoua", TweetTime = DateTime.Now ,Likedflag=false});
            alltweets.Add(new Tweet() { TweetID = 2, UserID = "2", Tweethandle = "ooyeoye", TweetMessage = "oooooooyeoua", TweetTime = DateTime.Now ,Likedflag=true});
        }
        public Tweet AddTweet(Tweet tweet)
        {
            throw new NotImplementedException();

        }

       
        public void DeleteTweet(Tweet tweet)
        {
            if (!(tweet is null)){

                alltweets.Remove(tweet);
            
            }
        }

        public List<Tweet> GetAllTweeets()
        {

            var temp = _Tweet.Find(new BsonDocument()).ToList();
            return temp;
        }

        public List<Tweet> GetUserTweeets(string loginid)
        {
            var filter = Builders<Tweet>.Filter.Eq("UserID", loginid);
            var tweets = _Tweet.Find<Tweet>(filter).ToList();
            //  var studentDocument = _Tweet.Find(filter).FirstOrDefault();
            return tweets;//alltweets.FindAll(x => x.UserID == loginid);
        }

        public void LikeTweet(Tweet tweet)
        {
            tweet.Likedflag = true;
        }

        public Tweet ReplyTweet(Tweet tweet)
        {
            throw new NotImplementedException();
        }

        public Tweet UpdateTweet(Tweet tweet)
        {
            throw new NotImplementedException();
        }
    }
}
