using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class MeleeToRangeAdapter : IRange
    {
        private IMelee _melee;
        public int Damage { get => _melee.Damage; }
        public int Radius { get => _melee.Speed * 2; }

        private int _ammo = 1;
        public int Ammo { get => _ammo; }

        public MeleeToRangeAdapter(IMelee melee)
        {
            _melee = melee;
        }

        public int Shoot(int distance)
        {
            if (_ammo > 0 && Radius >= distance)
            {
                _ammo -= 1;
                return Damage * (Radius - distance) / Radius;
            }
            else
            {
                return 0;
            }
        }
    }

    public class Player
    {
        private IRange _range;
        private IMelee _melee;

        public Player(IRange range, IMelee melee)
        {
            _range = range;
            _melee = melee;
        }

        public void Hit()
        {
            if (_melee != null)
            {
                Console.WriteLine("Melee damage: " + _melee.Hit().ToString());
            }
        }

        public void Shoot(int distance)
        {
            if (_range != null)
            {
                Console.WriteLine("Range damage: " + _range.Shoot(distance).ToString());
            }
        }
    }
}
