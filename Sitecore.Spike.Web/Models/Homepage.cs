using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Spike.Web.Models
{
    [SitecoreType(AutoMap = true)]
    public class Homepage
    {
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual IEnumerable<NewsArticle> News { get; set; }
    }
}