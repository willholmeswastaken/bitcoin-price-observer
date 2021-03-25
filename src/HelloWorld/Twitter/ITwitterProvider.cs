using System;
using System.Threading.Tasks;
using HelloWorld.BitcoinOps;
using Tweetinvi.Models;

namespace HelloWorld.Twitter
{
    public interface ITwitterProvider
    {
        Task<ITweet> SendTweet(BitcoinPrice price);
    }
}