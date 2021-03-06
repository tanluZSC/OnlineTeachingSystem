﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTeachingSystem.ViewModels
{
    public class AddArticleViewModel : BaseViewModel
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get; set; }
        public string Message { get; set; }
        public string AlertType { get; set; }
    }
}