using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scextender.Feature.Instagram.Models
{
    public class ImageDetails
    {
        public Uri ImageUri { get; set; }
        public String ImageCaption { get; set; }
        public int ImageCommentsCount { get; set; }
        public int ImageLikeCount { get; set; }
    }
}