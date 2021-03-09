using System;
using System.Threading.Tasks;
using System.Web;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using xamarinnewsApp.Models;

namespace xamarinnewsApp.ViewModels
{
    public class ArticlePageViewModel : BindableBase, IInitialize
    {
        private Article article;

        public Article Article { get => article; set { SetProperty(ref article, value); } }
        public ArticlePageViewModel()
        {
        }

        public void Initialize(INavigationParameters parameters)
        {
            Article = parameters.GetValue<Article>("article");
        }

    }
}
