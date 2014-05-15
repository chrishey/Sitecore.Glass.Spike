using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Sitecore.Spike.Web.Models
{
    public class NewsArticle
    {
        public virtual Guid Id { get; set; }
        [SitecoreField(FieldName = "Page Title")]
        public virtual string PageTitle { get; set; }
        public virtual string Abstract { get; set; }
        public virtual string MainBody { get; set; }
        public virtual Image FeaturedImage { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Url { get; set; }
    }
}