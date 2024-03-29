using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    public static class FactoryTest
    {
        public static void CreatureFactoryTest(ICreatureFactory factory)
        {
            var creature = factory.CreateCreature();
            Console.WriteLine($"{creature.GetType()} speed: {creature.Speed}");
        }
    }
}
