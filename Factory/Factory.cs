using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    public interface ICreatureFactory
    {
        ICreature CreateCreature();        
    }

    public class ZombiFactory : ICreatureFactory
    {
        private Random _randomProvider = new Random();
        public ZombiFactory(Random random)
        {
            _randomProvider = random; 
        }

        public ICreature CreateCreature()
        {
            var strength = _randomProvider.Next(2, 6);
            var speed = _randomProvider.Next(1, 3);
            return new Zombi(strength, speed);
        }
    }

    public class BanditFactory : ICreatureFactory
    {
        private Random _randomProvider = new Random();
        public BanditFactory(Random random)
        {
            _randomProvider = random; 
        }

        public ICreature CreateCreature()
        {
            var strength = _randomProvider.Next(4, 6);
            var speed = _randomProvider.Next(6, 12);
            var weaponId = _randomProvider.Next(0, 6);
            return new Bandit(strength, speed, weaponId);
        }
    }

}
