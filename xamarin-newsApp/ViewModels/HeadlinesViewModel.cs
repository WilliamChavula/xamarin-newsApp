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
        public NewsResult HeadlineNews { get; set; }
        public NewsResult MiddleEastNews { get; set; }
        public NewsResult AfricaNews { get; set; }
        public NewsResult EuropeNews { get; set; }
        public NewsResult GlobalNews { get; set; }

        public HeadlinesViewModel(INewsService newsService)
        {
            _newsService = newsService;
            GetNews();
        }

        private async void GetNews()
        {
            HeadlineNews = await ListToObservableCollection(NewsScope.Headlines);
            MiddleEastNews = await ListToObservableCollection(NewsScope.MiddleEast);
            AfricaNews = await ListToObservableCollection(NewsScope.Africa);
            EuropeNews = await ListToObservableCollection(NewsScope.Europe);
            GlobalNews = await ListToObservableCollection(NewsScope.Global);
        }

        private async Task<NewsResult> ListToObservableCollection(NewsScope newsScope)
        {
            return await _newsService.GetNews(newsScope);
        }
    }
}
