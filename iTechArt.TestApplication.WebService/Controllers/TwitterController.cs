using System;
using System.Web.Mvc;
using TweetSharp;

namespace iTechArt.TestApplication.WebService.Controllers
{
	public class TwitterController : System.Web.Http.ApiController
	{
		private static string consumer_key = "uBjUh8gbf7dHdPBLAAiDadOfP";
		private static string consumer_secret_key = "jraWuV52qBU8b5T4MrJHOHr54KtUq8qjznVfF5AfWabVWNJQcc";
		private static string access_token = "838757095579209730-gHRyFfywoe5v8qdffafxftetspdw6OU";
		private static string access_secret_token = "IlGp5zEtdhU0NkQU772LZ3kmjCHGi8yydTqrTPTQPaurU";

		TwitterService twitter = new TwitterService(consumer_key, consumer_secret_key, access_token, access_secret_token);
		

		[HttpGet]
		public JsonResult GetTweets()
		{
			
			//var options = new ListTweetsOnHomeTimelineOptions();
			//options.ExcludeReplies = true;
			//options.Count = 5;
			//twitter.Time
			SearchOptions options = new SearchOptions { Q = "#test", Resulttype = TwitterSearchResultType.Recent, Count=10};
			var searchedTweets = twitter.Search(options);
			//twitter.SendTweet(new SendTweetOptions { Status = "Hello, world!" });
			//var tweets = twitter.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions { Count = 200 , SinceId=0 });
			//IEnumerable<TwitterStatus> tweets = twitter.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions() { Count = 5 });
			return new JsonResult()
			{
				Data = searchedTweets,
				JsonRequestBehavior = JsonRequestBehavior.AllowGet,
				MaxJsonLength = Int32.MaxValue
			};
		}

	}
}
