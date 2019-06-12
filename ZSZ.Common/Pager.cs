using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSZ.Common
{
    public class Pager
    {
        /// <summary>
        /// 每页数据条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总数据条数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 点击页码的跳转链接
        /// </summary>
        public string UrlPatten { get; set; }

        /// <summary>
        /// 最多的页码数
        /// </summary>
        public int MaxPageCount { get; set; }

        /// <summary>
        /// 当前页码的样式名称
        /// </summary>
        public string CurrentLinkClassName { get; set; }

        public Pager()
        {
            this.PageSize = 10;
            this.MaxPageCount = 10;
        }

        public string GetPager()
        {
            StringBuilder sb = new StringBuilder();

            //计算出来的页数
            int pageCount = (int)Math.Ceiling(TotalCount * 1.0f / PageSize);
            //起始页码
            int startPageIndex = Math.Max(1, PageIndex - MaxPageCount / 2);
            //结束页码
            int endPageIndex = Math.Min(pageCount, PageIndex + MaxPageCount / 2);

            sb.Append("<ul>");
            if (PageIndex != 1)
            {
                sb.AppendLine("<li><a href='" + UrlPatten.Replace("{Rn}", (PageIndex - 1).ToString()) + "'>上一页</a></li>");
            }
            for (int i = startPageIndex; i <= endPageIndex; i++)
            {
                
                if (i == PageIndex)
                {
                    sb.AppendLine("<li class='" + CurrentLinkClassName + "'>" + i + "</li>");
                }
                else
                {
                    sb.AppendLine("<li><a href='" + UrlPatten.Replace("{Rn}", i.ToString()) + "'>" + i + "</a></li>");
                }
            }
            if (PageIndex != pageCount)
            {
                sb.AppendLine("<li><a href='" + UrlPatten.Replace("{Rn}", (PageIndex + 1).ToString()) + "'>下一页</a></li>");
            }
            sb.Append("</ul>");
            return sb.ToString();
        }
    }
}
