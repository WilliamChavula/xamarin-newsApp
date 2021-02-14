using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Mvvm;
using xamarinnewsApp.Models;
using xamarinnewsApp.Services;

namespace xamarinnewsApp.ViewModels
{
    public class HeadlinesViewModel : BindableBase
    {
        private readonly INewsService _newsService;
        public ObservableCollection<Article> HeadlineArticles { get; set; }
        public ObservableCollection<Article> MiddleEastArticles { get; set; }

        public HeadlinesViewModel(INewsService newsService)
        {
            _newsService = newsService;
            HeadlineArticles = new ObservableCollection<Article>();
            MiddleEastArticles = new ObservableCollection<Article>();
            GetNews(HeadlineArticles, NewsScope.Headlines);
            GetNews(MiddleEastArticles, NewsScope.MiddleEast);
        }

        private async void GetNews(ObservableCollection<Article> collection, NewsScope news)
        {
            NewsResult result = await GetScopedNews(news);
            LoadCollection(collection, result);

        }

        private void LoadCollection(ObservableCollection<Article> collection, NewsResult result)
        {
            collection.Clear();
            foreach (Article article in result.Articles)
            {
                collection.Add(article);
            }
        }

        private async Task<NewsResult> GetScopedNews(NewsScope newsScope)
        {
            return await _newsService.GetNews(newsScope);
        }

    }
}
