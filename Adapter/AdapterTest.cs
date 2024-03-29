using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public static class AdapterTest
    {
        public static void RangeAdapterTest()
        {
            IMelee knife = new Melee(2, 4);
            IMelee sword = new Melee(4, 1);

            Player player = new Player(new MeleeToRangeAdapter(knife), sword);
            player.Hit();
            player.Shoot(2);
            player.Shoot(4);
        }
    }
}
