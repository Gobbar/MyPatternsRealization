using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    internal static class AbstractFactoryTest
    {
        public static void ArmorFactoryTest(IArmorFactory factory)
        {
            IHelmet helmet = factory.CreateHelmet();
            IChestplate chestplate = factory.CreateChestplate();
            IBoot boot = factory.CreateBoot();

            Console.WriteLine("Helmet protection: " + helmet.Protection.ToString());
            Console.WriteLine("Chestplate protection: " + chestplate.Protection.ToString());
            Console.WriteLine("Boot protection: " + boot.Protection.ToString());
        }
    }
}
