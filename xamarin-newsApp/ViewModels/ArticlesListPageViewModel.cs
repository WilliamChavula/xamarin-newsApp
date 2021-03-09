using System;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Mvvm;
using Prism.Navigation;
using xamarinnewsApp.Models;

namespace xamarinnewsApp.ViewModels
{
    public class ArticlesListPageViewModel : BindableBase, IInitialize
    {
        private Article singleArticle;

        public Article SingleArticle { get => singleArticle; set => SetProperty(ref singleArticle, value); }
        public ObservableCollection<Article> Articles { get; set; }

        public ArticlesListPageViewModel()
        {
        }

        public void Initialize(INavigationParameters parameters)
        {
            var articles = parameters.GetValues<NewsResult>("articles");

            var temp = articles.FirstOrDefault();
            LoadAllCollections(Articles, temp);
        }

        private void LoadAllCollections(ObservableCollection<Article> collection, NewsResult result)
        {
            collection.Clear();
            foreach (Article article in result.Articles)
            {
                collection.Add(article);
            }
        }
    }
}
