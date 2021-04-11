//using TheCodeAttic.Layer.ModuleName.Factories;
//using TheCodeAttic.Layer.ModuleName.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace TheCodeAttic.Layer.ModuleName.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<IHeroService, HeroService>();
            //serviceCollection.AddTransient<IHeroViewModelFactory, HeroViewModelFactory>();
        }
    }
}
