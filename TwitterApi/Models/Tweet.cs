using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterAPI.Models
{
    public class Tweet
    {
        public DateTime TweetTime { get; set; }

        public string TweetMessage { get; set; }

        public string Tweethandle { get; set; }

        public string UserID { get; set; }
        public int TweetID { get; set; }

        public bool Likedflag { get; set; }
    }
}
