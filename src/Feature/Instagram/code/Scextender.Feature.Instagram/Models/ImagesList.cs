using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scextender.Feature.Instagram.Models
{
    public class ImagesList
    {
        public IEnumerable<ImageDetails> Images;
        public int TotalResultCount;
        public int PageSize;
    }
}