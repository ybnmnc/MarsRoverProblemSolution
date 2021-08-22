using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblemSolution.Tests
{
    public abstract class TestBase
    {
        public virtual IServiceProvider Initialize(Action<IServiceCollection> action = null)
        {
            var services = new ServiceCollection();
        
            //var mockDataService = new Mock<DataService.IDataService>();
            //var mockCustomerService = new Mock<CustomerService.ICustomerService>();
            //var mockCampaignService = new Mock<CampaignService.ICampaignService>();

            //services.AddSingleton(mockDataService.Object);
            //services.AddSingleton(mockCustomerService.Object);
            //services.AddSingleton(mockCampaignService.Object);
            //services.AddSingleton<Pars.Core.Localization.Cache.SimpleCacheHelper>();
            //services.AddSingleton<ConfigurationParameterDaoImpl>();
            //services.AddSingleton<Business.Services.LocationService>();
            //services.AddSingleton<LocationCountryDaoImp>();


            action?.Invoke(services);

            var provider = services.BuildServiceProvider();

            return provider;
        }
    }
}
