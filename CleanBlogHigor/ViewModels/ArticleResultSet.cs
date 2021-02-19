using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace CleanBlogHigor.ViewModels
{
    public class ArticleResultSet
    {
        public IEnumerable<IPublishedContent> Results { get; set; }

        public int PageSize { get; set; }
        
        public int PageNumber { get; set; }
        
        public double PageCount { get; set; }
        
        public bool IsArticleListPage { get; set; }
        
        public string Url { get; set; }
    }
}