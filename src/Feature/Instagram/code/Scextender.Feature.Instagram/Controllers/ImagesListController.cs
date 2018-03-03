using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scextender.Feature.Instagram.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Scextender.Feature.Instagram.Controllers
{
    public class ImagesListController : StandardController
    {
        protected readonly IImagesListRepository ImageRepository;

        public ImagesListController(IImagesListRepository imageRepository)
        {
            this.ImageRepository = imageRepository;
        }

        public ActionResult ImagesListIndex() => PartialView();

        protected override object GetModel()
        {
            return ImageRepository.GetModel();
        }
    }
}