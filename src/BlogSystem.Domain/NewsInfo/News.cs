using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Youshow.Ace.Domain.Models;

namespace BlogSystem.Domain.NewsInfo
{
    public class News : BaseModel<int>
    {
        [Comment("文章作者")]
        public string Author { get; set; }
        [Comment("文章标题")]
        public string Title { get; set; }
        [Comment("文章内容")]
        public string Content { get; set; }
        [Comment("文章摘要")]
        public string Key { get; set; }
        [Comment("文章类型Id")]
        public int CategoryId { get; set; }
        [Comment("文章类型名称")]
        public string CategoryName { get; set; }
        [Comment("文章回复数")]
        public int ReplyCount { get; set; }

        /// <summary>
        /// 敏感词过滤
        /// </summary>
        /// <returns></returns> <summary>
        public string ContentFilter()
        {
            return this.Content.Replace("的", "地").Replace(">", "&gt;");
        }
    }
}