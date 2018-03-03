using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Models;
using Sitecore.XA.Foundation.Multisite.LinkManagers;

namespace Scextender.Feature.Instagram.Models
{
    public class ImageRenderingModel: RenderingModelBase
    {
        public bool HasImageCaption { get; set; }

        public bool HasImageDescription { get; set; }

        public MvcHtmlString Image { get; set; }

        public LinkItem LinkItem { get; set; }

        public string ExternalImageLink { get; set; }
    }
}