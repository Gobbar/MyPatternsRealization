using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DI_IoC
{
    public static class DITest
    {
        public static void Test()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IDependencyService, DependencyService>();
            serviceCollection.AddScoped<ITestService, TestService>();
            //serviceCollection.AddService();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var testService = serviceProvider.GetService<ITestService>();
            testService?.DoSmthng();
        }
    }
}
