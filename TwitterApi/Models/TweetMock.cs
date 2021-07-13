using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterAPI.Models
{
    public class TweetMock : ITwitterRepository
    {

        private List<Tweet> alltweets;
        private Tweet tweets;

        public TweetMock()
        {
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
            return alltweets;
        }

        public List<Tweet> GetUserTweeets(string loginid)
        {
            return alltweets.FindAll(x => x.UserID == loginid);
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
