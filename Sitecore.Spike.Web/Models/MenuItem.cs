using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Spike.Web.Models
{
    [SitecoreType(AutoMap = true)]
    public class MenuItem
    {
        public virtual string Title { get; set; }

        public virtual string Url { get; set; }

        public virtual IEnumerable<MenuItem> Children { get; set; }
    }
}