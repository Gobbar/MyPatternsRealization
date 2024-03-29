using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DI_IoC
{
    public interface ITestService
    {
        void DoSmthng();
    }
    public class TestService : ITestService
    {
        private IDependencyService _service;
        public TestService(IDependencyService dependencyService)
        {
            _service = dependencyService;
        }

        public void DoSmthng()
        {
            _service.DependencyMethod();
            Console.WriteLine("DoSmthng");
        }
    }

    public interface IDependencyService
    {
        void DependencyMethod();
    }

    public class DependencyService : IDependencyService
    {
        public void DependencyMethod()
        {
            Console.WriteLine("DependencyMethod");
        }
    }
}
