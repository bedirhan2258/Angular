﻿
using System;

namespace AngularBlok.API.Responses
{
    public class ArticleResponse
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string ContentMain { get; set; }
        public string ContentSummary { get; set; }
        public DateTime PublishDate { get; set; }
        public string Picture { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public CategoryResponse Category { get; set; }
    }
}
