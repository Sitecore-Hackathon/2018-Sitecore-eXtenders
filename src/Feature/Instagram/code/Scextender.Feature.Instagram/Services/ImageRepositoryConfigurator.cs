using Microsoft.Extensions.DependencyInjection;
using Scextender.Feature.Instagram.Controllers;
using Scextender.Feature.Instagram.Repositories;
using Sitecore.DependencyInjection;

namespace Scextender.Feature.Instagram.Services
{
    public class ImageRepositoryConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IImagesListRepository, ImagesListRepository>();
            serviceCollection.AddTransient<ImagesListController>();
        }

    }
}