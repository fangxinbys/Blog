using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class ArticleMessage
    {
        public string VisitorName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset LeaveMessageTime { get; set; }
    }
}
