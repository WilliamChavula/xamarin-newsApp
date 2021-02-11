using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using xamarinnewsApp.Models;

namespace xamarinnewsApp.Services
{
    public class NewsService : INewsService
    {
        public async Task<NewsResult> GetNews(NewsScope scope)
        {
            string url = GetUrl(scope);

            WebClient webClient = new WebClient();
            string json = await webClient.DownloadStringTaskAsync(url);

            return JsonConvert.DeserializeObject<NewsResult>(json);
        }

        private string GetUrl(NewsScope scope)
        {
            return scope switch
            {
                NewsScope.Headlines => Headlines,
                NewsScope.Global => Global,
                NewsScope.Africa => Africa,
                NewsScope.Europe => Europe,
                NewsScope.MiddleEast => MiddleEast,
                _ => throw new Exception("Undefined scope")
            };
        }

        private string Headlines => $"https://newsapi.org/v2/top-headlines?country=us&apiKey={Settings.NewsApiKey}";
        private string Global => $"https://newsapi.org/v2/everything?q=global&apiKey={Settings.NewsApiKey}";
        private string Africa => $"https://newsapi.org/v2/everything?q=africa&apiKey={Settings.NewsApiKey}";
        private string Europe => $"https://newsapi.org/v2/everything?q=europe&apiKey={Settings.NewsApiKey}";
        private string MiddleEast => $"https://newsapi.org/v2/everything?q=middle-east&apiKey={Settings.NewsApiKey}";
    }
}
