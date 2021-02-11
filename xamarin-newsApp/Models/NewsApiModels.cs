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
        public Source Source;
        public string Author;
        public string Title;
        public string Description;
        public string Url;
        public string UrlToImage;
        public DateTime PublishedAt;
        public string Content;
    }

    public class NewsResult
    {
        public List<Article> Articles;
    }
}
