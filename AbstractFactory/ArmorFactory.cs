using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public interface IArmorFactory
    {
        IHelmet CreateHelmet();
        IChestplate CreateChestplate();
        IBoot CreateBoot();
    }

    public class IronArmorFactory : IArmorFactory
    {
        private Random _randomProvider;

        public IronArmorFactory(Random randomProvider)
        {
            _randomProvider = randomProvider;
        }

        public IHelmet CreateHelmet()
        {
            int protection = _randomProvider.Next(2, 4);
            return new IronHelmet(protection);
        }
        
        public IChestplate CreateChestplate()
        {
            int protection = _randomProvider.Next(4, 8);
            return new IronChestplate(protection);
        }

        public IBoot CreateBoot()
        {
            int protection = _randomProvider.Next(4, 6);
            return new IronBoot(protection);
        }
    }
    
    public class SteelArmorFactory : IArmorFactory
    {
        private Random _randomProvider;
        public SteelArmorFactory(Random randomProvider)
        {
            _randomProvider = randomProvider;
        }

        public IHelmet CreateHelmet()
        {
            int protection = _randomProvider.Next(8, 16);
            return new SteelHelmet(protection);
        }
        
        public IChestplate CreateChestplate()
        {
            int protection = _randomProvider.Next(16, 32);
            return new SteelChestplate(protection);
        }

        public IBoot CreateBoot()
        {
            int protection = _randomProvider.Next(16, 24);
            return new SteelBoot(protection);
        }

    }
}
