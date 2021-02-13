using System;
using System.Collections.Generic;

namespace xamarinnewsApp.Models
{
    public class Source
    {
        public string Id;
        public string Name;
    }

    public class Article
    {
        public string Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public string PublishedAt { get; set; }
        public string Content { get; set; }
    }

    public class NewsResult
    {
        public List<Article> Articles;
    }

    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFavorite { get; set; }
    }
}
