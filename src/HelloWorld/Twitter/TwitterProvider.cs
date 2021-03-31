using System;
using System.Threading.Tasks;
using HelloWorld.BitcoinOps;
using Tweetinvi;
using Tweetinvi.Models;

namespace HelloWorld.Twitter
{
    public class TwitterProvider : ITwitterProvider
    {
        private readonly TwitterClient _client;

        public TwitterProvider()
        {
            _client = new TwitterClient(Environment.GetEnvironmentVariable("CONSUMER_KEY"),
                Environment.GetEnvironmentVariable("CONSUMER_SECRET"),
                Environment.GetEnvironmentVariable("ACCESS_KEY"), Environment.GetEnvironmentVariable("ACCESS_SECRET"));
        }

        public async Task<ITweet> SendTweet(BitcoinPrice price)
        {
            var changed = price.LastDayChange < 0 ? "decreased" : "increased";
            var tweet = $"The current price of bitcoin is {price.Current.ToString("C")}. It has {changed} by {price.LastDayChange.ToString("F")}% in the last 24 hours #bitcoin #btc #cryptocurrency";
            return await _client.Tweets.PublishTweetAsync(tweet);
        }
    }
}