using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using xamarinnewsApp.Models;
using xamarinnewsApp.Services;

namespace xamarinnewsApp.ViewModels
{
    public class HeadlinesViewModel : BindableBase
    {
        // Fields
        public INavigationService _navigationService;
        private readonly INewsService _newsService;

        // Properties
        private Article selectedItem;
        public Article SelectedItem { get => selectedItem; set { SetProperty(ref selectedItem, value); } }
        public ObservableCollection<Article> HeadlineArticles { get; set; }
        public ObservableCollection<Article> MiddleEastArticles { get; set; }
        public ObservableCollection<Article> HeadlineArticlesAll { get; set; }
        public ObservableCollection<Article> MiddleEastArticlesAll { get; set; }
        public ObservableCollection<Article> AfricaArticles { get; set; }
        public ObservableCollection<Article> EuropeArticles { get; set; }
        public ObservableCollection<Article> GlobalArticles { get; set; }

        // Commands
        public Command SelectedItemCommand { get; set; }


        public HeadlinesViewModel(INewsService newsService, INavigationService navigationService)
        {
            _navigationService = navigationService;
            _newsService = newsService;


            HeadlineArticles = new ObservableCollection<Article>();
            MiddleEastArticles = new ObservableCollection<Article>();
            HeadlineArticlesAll = new ObservableCollection<Article>();
            MiddleEastArticlesAll = new ObservableCollection<Article>();
            AfricaArticles = new ObservableCollection<Article>();
            EuropeArticles = new ObservableCollection<Article>();
            GlobalArticles = new ObservableCollection<Article>();

            // Filtered Articles
            GetNews(HeadlineArticles, NewsScope.Headlines);
            GetNews(MiddleEastArticles, NewsScope.MiddleEast);

            // All Articles
            GetAllNews(HeadlineArticlesAll, NewsScope.Headlines);
            GetAllNews(MiddleEastArticlesAll, NewsScope.MiddleEast);
            GetAllNews(AfricaArticles, NewsScope.Africa);
            GetAllNews(EuropeArticles, NewsScope.Europe);
            GetAllNews(GlobalArticles, NewsScope.Global);

            SelectedItemCommand = new Command<string>(OpenArticle);


        }

        private void OpenArticle(object obj)
        {
            if (SelectedItem == null)
                return;
            var navParams = new NavigationParameters
            {
                {"article", SelectedItem }
            };

            _navigationService.NavigateAsync("ArticlePage", navParams);
            SelectedItem = null;
        }



        private async void GetNews(ObservableCollection<Article> collection, NewsScope news)
        {
            NewsResult result = await GetScopedNews(news);
            List<Article> newsResult = result.Articles.GetRange(0, 5);
            LoadCollection(collection, newsResult);

        }

        private async void GetAllNews(ObservableCollection<Article> collection, NewsScope news)
        {
            NewsResult result = await GetScopedNews(news);
            LoadAllCollections(collection, result);

        }

        private void LoadCollection(ObservableCollection<Article> collection, List<Article> newsResult)
        {
            collection.Clear();
            foreach (Article article in newsResult)
            {
                collection.Add(article);
            }
        }

        private void LoadAllCollections(ObservableCollection<Article> collection, NewsResult result)
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
