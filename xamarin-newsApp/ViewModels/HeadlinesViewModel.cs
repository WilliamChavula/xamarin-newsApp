using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Prism.Mvvm;
using xamarinnewsApp.Models;
using xamarinnewsApp.Services;

namespace xamarinnewsApp.ViewModels
{
    public class HeadlinesViewModel : BindableBase
    {
        readonly IList<Monkey> source;
        private readonly INewsService _newsService;

        public ObservableCollection<Article> Articles { get; set; }

        public HeadlinesViewModel(INewsService newsService)
        {
            _newsService = newsService;
            Articles = new ObservableCollection<Article>();
            GetNews();
        }

        private void GetNews()
        {
            Articles.Clear();
            Articles.Add(new Article
            {

                Author = "",
                Title = "Chris Doyle resigns from Jacksonville Jaguars coaching staff after backlash, per report - CBS Sports",
                Description = "Doyle's resignation comes just one day after his hiring was announced",
                Url = "https://www.cbssports.com/nfl/news/chris-doyle-resigns-from-jacksonville-jaguars-coaching-staff-after-backlash-per-report/",
                UrlToImage = "https://sportshub.cbsistatic.com/i/r/2020/06/06/0cc1de7f-e541-4d15-997b-3a07fd108595/thumbnail/1200x675/e06338e0fc01ba092ff7d2db49136c47/chris-doyle.jpg",
                PublishedAt = "2021-02-13T05:06:00Z",
                Content = "Chris Doyle has resigned from the Jacksonville Jaguars coaching staff just one day after his controversial hiring was announced, according to ESPN's Adam Schefter. Doyle was hired by new head coach U… [+3590 chars]",
                Source = "CBS Sports"
            });
            Articles.Add(new Article
            {

                Author = "By <a href=\"/profiles/james-griffiths\">James Griffiths</a> and <a href=\"/profiles/brett-mckeehan\">Brett McKeehan</a>, CNN",
                Title = "The latest on the coronavirus pandemic and vaccines: Live updates - CNN ",
                Description = "The coronavirus pandemic has brought countries to a standstill. Meanwhile, vaccinations have already started in some countries as cases continue to rise. Follow here for the latest.",
                Url = "https://www.cnn.com/world/live-news/coronavirus-pandemic-vaccine-updates-02-13-21/index.html",
                UrlToImage = "https://cdn.cnn.com/cnnnext/dam/assets/200213175739-03-coronavirus-0213-super-tease.jpg",
                PublishedAt = "2021-02-13T05:00:00Z",
                Content = "The US state of California is adding millions of people to its Covid-19 vaccination priority list, including residents at high risk with developmental and other disabilities\" and those with serious u… [+2465 chars]",
                Source = "CNN"
            });
            Articles.Add(new Article
            {

                Author = "Kyle Cheney",
                Title = "House Republican pleads for Pence, Trump aides to speak out on Jan. 6 insurrection - POLITICO",
                Description = "\"To the patriots who were standing next to the former president as these conversations were happening, or even to the former Vice President: if you have something to add here, now would be the time,\" Herrera Beutler (R-Wash.) wrote in a statement released lat…",
                Url = "https://www.politico.com/news/2021/02/12/house-republicans-pence-trump-riot-468983",
                UrlToImage = "https://static.politico.com/cd/d1/3b2228f74bf1be43a47b82a76950/gettyimages-1217509180-1.jpg",
                PublishedAt = "2021-02-13T04:13:00Z",
                Content = "In Herrera Beutler's telling, McCarthy urged Trump to call off the mob, to which Trump initially responded that he couldn't because it was made up of left-wing extremists a falsehood that has been de… [+2265 chars]",
                Source = "Politico"
            });
            Articles.Add(new Article
            {

                Author = "Nate Day",
                Title = "Britney Spears' sister Jamie Lynn Spears speaks out after court rules for co-conservatorship - Fox News",
                Description = "Jamie Lynn Spears, sister of \"Toxic\" singer Britney Spears, has spoken out following the release of the documentary \"Framing Britney Spears\" and the court ruling in favor of a co-conservatorship over the pop star.",
                Url = "https://www.foxnews.com/entertainment/britney-spears-sister-jamie-lynn-spears-speaks-out",
                UrlToImage = "https://static.foxnews.com/foxnews.com/content/uploads/2019/04/Jamie-Lynn-Britney-Spears-Getty.jpg",
                PublishedAt = "2021-02-13T02:55:32Z",
                Content = "Britney Spears is being supported by her sister Jamie Lynn Spears.\r\nThe pop star has found herself in the headlines once again following both the release of the unauthorized documentary \"Framing Brit… [+2503 chars]",
                Source = "Fox News"
            });
            Articles.Add(new Article
            {

                Author = "Sam Dorman",
                Title = "Impeachment aide says graphic accidentally included fake blue check on tweet shown in trial - Fox News",
                Description = "A senior impeachment aide said the inclusion of a fake blue check verification mark on tweets that were presented at the Senate trial was an accident.",
                Url = "https://www.foxnews.com/politics/impeachment-team-fake-blue-check-tweet-impeachment",
                UrlToImage = "https://static.foxnews.com/foxnews.com/content/uploads/2021/01/Eric-Swalwell.jpg",
                PublishedAt = "2021-02-13T02:06:05Z",
                Content = "A senior impeachment aide said the inclusion of a fake blue check verification mark on tweets that were presented at the Senate trial was an accident.\r\nThe tweets showed comments from Jennifer Lynn L… [+2106 chars]",
                Source = "Fox News"
            });
            Articles.Add(new Article
            {

                Author = "Matthew Ismael Ruiz",
                Title = "Donald Glover and Phoebe Waller-Bridge to Star in Mr. & Mrs. Smith Series - Pitchfork",
                Description = "The series is set to debut on Amazon Prime Video next year",
                Url = "https://pitchfork.com/news/donald-glover-and-phoebe-waller-bridge-to-star-in-mr-and-mrs-smith-series/",
                UrlToImage = "https://media.pitchfork.com/photos/602729ff874cf4bfd7794c7f/16:9/w_1280,c_limit/Childish_Waller-Bridge.jpg",
                PublishedAt = "2021-02-13T01:36:33Z",
                Content = "Donald Glover and Phoebe Waller-Bridge have signed up to play the titular roles in an Amazon Studios TV adaptation of Mr. &amp; Mrs. Smith, a 2005 film starring Brad Pitt and Angelina Jolie as marrie… [+717 chars]",
                Source = "Pitchfork"
            });
            Articles.Add(new Article
            {

                Author = "Deidre McPhillips, CNN",
                Title = "Nearly all US kids live in red zones under new CDC school guidance - CNN ",
                Description = "About 99% of children in the US live in a county considered a \"red\" zone with high levels of Covid-19 transmission under new US Centers for Disease Control and Prevention school opening guidance, according to a CNN analysis of federal data.",
                Url = "https://www.cnn.com/2021/02/12/health/us-kids-red-zones-cdc-school-guidelines/index.html",
                UrlToImage = "https://cdn.cnn.com/cnnnext/dam/assets/201112203608-schools-covid-19-return-to-online-super-tease.jpg",
                PublishedAt = "2021-02-13T01:19:00Z",
                Content = null,
                Source = "CNN"
            });
            Articles.Add(new Article
            {

                Author = "Dan Heching",
                Title = "Sia drops new video 1+1 from her controversial feature film debut Music featuring Kate Hudson - Daily Mail",
                Description = "It's been nominated for two high-profile Golden Globes, in spite of controversial depictions of autism and largely negative reviews from fans and critics.",
                Url = "https://www.dailymail.co.uk/tvshowbiz/article-9255549/Sia-drops-new-video-1-1-controversial-feature-film-debut-Music-featuring-Kate-Hudson.html",
                UrlToImage = "https://i.dailymail.co.uk/1s/2021/02/12/22/39229408-0-image-a-4_1613169515713.jpg",
                PublishedAt = "2021-02-13T00:55:00Z",
                Content = "Its been nominated for two high-profile Golden Globes, in spite of controversial depictions of autism and largely negative reviews from fans and critics.\r\nBut Sias new film Music is continuing to hyp… [+3718 chars]",
                Source = "Daily Mail"
            });
            Articles.Add(new Article
            {

                Author = "Corinne Reichert",
                Title = "GameStop hearing will include Robinhood and Reddit CEOs - CNET",
                Description = "The House Financial Committee will also hear from the CEOs of Citadel and Melvin Capital, as well as Redditor Keith Gill.",
                Url = "https://www.cnet.com/news/gamestop-hearing-will-include-robinhood-and-reddit-ceos/",
                UrlToImage = "https://cnet2.cbsistatic.com/img/cqla8PWjMTdvNnkP6vQwkwXFtvE=/1200x630/2020/04/14/904dbbcb-8c07-499b-81ba-a0e9fafd2ba1/reddit-logo-0893.jpg",
                PublishedAt = "2021-02-13T00:52:00Z",
                Content = "The House will hear from Reddit and Robinhood during a hearing on GameStop next week.\r\nAngela Lang/CNET\r\nThe House Financial Services Committee has announced the lineup for its GameStop hearing next … [+1378 chars]",
                Source = "CNET"
            });
            Articles.Add(new Article
            {

                Author = "Timothy Rodriguez",
                Title = "Jets: 3 free agents who could alter 2021 NFL Draft plans - With the First Pick",
                Description = "The New York Jets now stand a decade removed from their back to back AFC title game trips. When that scrappy team, that had just knocked off the 14-2 New E...",
                Url = "https://withthefirstpick.com/2021/02/12/jets-free-agents-draft-plans/",
                UrlToImage = "https://images2.minutemediacdn.com/image/fetch/w_2000,h_2000,c_fit/https%3A%2F%2Fwiththefirstpick.com%2Fwp-content%2Fuploads%2Fimagn-images%2F2017%2F07%2F15478580.jpeg",
                PublishedAt = "2021-02-13T00:37:22Z",
                Content = "The New York Jets now stand a decade removed from their back to back AFC title game trips. When that scrappy team, that had just knocked off the 14-2 New England Patriots a week prior, walked off Hei… [+1559 chars]",
                Source = "With the First Pick"
            });
            Articles.Add(new Article
            {

                Author = "Michael Ruiz",
                Title = "Flashback: NY Gov. Cuomo disbands his own ethics watchdog commission - Fox News",
                Description = "New York Gov. Andrew Cuomo drew calls for his resignation or impeachment this week after damaging new details emerged about the state’s handling of the coronavirus outbreak in nursing homes and subsequent withholding of vital information on the death toll – w…",
                Url = "https://www.foxnews.com/politics/flashback-ny-cuomo-disbands-ethics-watchdog-commission",
                UrlToImage = "https://static.foxnews.com/foxnews.com/content/uploads/2021/02/AP21043572585845-e1613171749995.jpg",
                PublishedAt = "2021-02-13T00:20:29Z",
                Content = "New YorkGov. Andrew Cuomo drew calls for his resignation or impeachment this week after damaging new details emerged about the states handling of the coronavirus outbreak in nursing homes and subsequ… [+3448 chars]",
                Source = "Fox News"
            });
            Articles.Add(new Article
            {

                Author = "Ellen Mitchell",
                Title = "Pentagon approves 20 additional COVID-19 vaccination teams | TheHill - The Hill",
                Description = "The Pentagon has approved 20 more military teams, a combined total of 4,700 service members,...",
                Url = "https://thehill.com/policy/defense/538691-pentagon-approves-20-additional-covid-19-vaccination-teams",
                UrlToImage = "https://thehill.com/sites/default/files/militarycoronavirusvaccinesite_02042021getty.png",
                PublishedAt = "2021-02-12T23:24:49Z",
                Content = "The Pentagon has approved 20 more military teams, a combined total of 4,700 service members, to help the Federal Emergency Management Agency (FEMA) administer COVID-19 vaccines across the country.\r\nF… [+2275 chars]",
                Source = "The Hill"
            });
        }


        /*
        private async Task<NewsResult> ListToObservableCollection(NewsScope newsScope)
        {
            return await _newsService.GetNews(newsScope);
        } */

    }
}
