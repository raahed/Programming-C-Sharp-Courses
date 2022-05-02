﻿
namespace Prog2_Practis6
{
    public class ArticleBook : Article
    {
        private string _title;

        private string _author;

        private string _publisher;

        public ArticleBook(string title, string author, string publisher, uint article, uint price) : base(article, price)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
        }
    }
}
