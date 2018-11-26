using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Tweetinvi;

namespace TwitterTest
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET_KEY, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            var matchingTweets = Search.SearchTweets("transportation");
            var json = Tweetinvi.JsonSerializer.ToJson(matchingTweets);
            string jsonFormatted = JValue.Parse(json).ToString(Formatting.Indented);
            Console.WriteLine(jsonFormatted);
        }
    }
}