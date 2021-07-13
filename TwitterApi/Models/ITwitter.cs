using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterAPI.Models
{
   public interface ITwitterRepository
    {

        List<Tweet> GetAllTweeets();

        List<Tweet> GetUserTweeets(string loginid);
        Tweet AddTweet(Tweet tweet);
        Tweet UpdateTweet(Tweet tweet);
        void DeleteTweet(Tweet tweet);
        void LikeTweet(Tweet tweet);
        Tweet ReplyTweet(Tweet tweet);



    }
}
