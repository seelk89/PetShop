using Microsoft.Extensions.DependencyInjection;
using PetShop.Core.ApplicationService;
using PetShop.Core.DomainService;
using PetShop.Infrastructure;

namespace PetShop.UI
{
    class PetShopMain
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<IPetShopRepository, PetShopRepository>();
            serviceCollection.AddScoped<IPetShopService, PetShopService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var petShopService = serviceProvider.GetRequiredService<IPetShopService>();
            var UI = new PetShopUI(petShopService);

            FakeDB.InitOwnerData();
            FakeDB.InitPetData();
            UI.StartUI();
        }
    }
}
