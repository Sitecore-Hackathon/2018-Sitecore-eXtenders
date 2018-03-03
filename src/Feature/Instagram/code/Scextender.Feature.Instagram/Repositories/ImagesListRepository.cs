using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scextender.Feature.Instagram.Models;
using Sitecore.XA.Foundation.Multisite.LinkManagers;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace Scextender.Feature.Instagram.Repositories
{
    public class ImagesListRepository : ModelRepository, IImagesListRepository
    {
    
        public override IRenderingModelBase GetModel()
        {
            ImageRenderingModel imageRenderingModel = new ImageRenderingModel();
            FillBaseProperties(imageRenderingModel);
            imageRenderingModel.HasImageCaption = true;
            imageRenderingModel.HasImageDescription = true;
            imageRenderingModel.LinkItem = new LinkItem();
            imageRenderingModel.ExternalImageLink = "http:\\www.google.com";
            
            return imageRenderingModel;
        }
}
}