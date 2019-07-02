using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class Article
    {
        public Article()
        { }
        public Article(string title,ArticleType articleType,string content)
        {
            this.Title = title;
            this.ArticleType = articleType;
            this.Content = content;
            this.CreateTime = DateTimeOffset.Now;
            this.Hits = 0;
            this.ArticleMessages = new List<ArticleMessage>();
        }
        public string Title
        {
            get;
            private set;
        }
        public string Content
        {
            get;
            private set;
        }
        public int Hits
        {
            get;
            private set;
        }
        public DateTimeOffset CreateTime
        {
            get;
            private set;
        }
        public ArticleType ArticleType
        {
            get;
            private set;
        }
        public IList<ArticleMessage> ArticleMessages
        {
            get;
            private set;
        }
        public void ChangeTitle(string title)
        {
            this.Title = title;
        }
        public void ChangeConTent(string content)
        {
            this.Content = content;
        }
        public void AddMessage(ArticleMessage message)
        {
            this.ArticleMessages.Add(message);
        }
        public void RemoveMessage(ArticleMessage message)
        {
            var removeItem = ArticleMessages.FirstOrDefault(t => t.Id == message.Id);
            ArticleMessages.Remove(removeItem);
        }
        public void ClearMessage()
        {
            ArticleMessages.Clear();
        }
        public void ChangeArticleType(ArticleType articleType)
        {
            this.ArticleType = articleType;
        }
        public void AddHits()
        {
            this.Hits++;
        }
    }
}
