using System;
using Prism;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarinnewsApp.Services;
using xamarinnewsApp.ViewModels;
using xamarinnewsApp.Views;

namespace xamarin_newsApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("Headlines");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Headlines, HeadlinesViewModel>();
            containerRegistry.RegisterSingleton<INewsService, NewsService>();

        }


    }
}
