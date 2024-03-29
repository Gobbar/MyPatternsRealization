using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public interface IRange
    {
        int Damage { get; }
        int Radius { get; }
        int Ammo { get; }

        int Shoot(int distance);
    }

    public class Range: IRange
    {
        private int _damage;
        public virtual int Damage { get => _damage; }

        private int _radius;
        public virtual int Radius { get => _radius; }

        private int _ammo = 10;
        public int Ammo { get => _ammo; }

        public Range(int damage, int radius)
        {
            _damage = damage;
            _radius = radius;
        }

        public int Shoot(int distance)
        {
            return Damage * (Radius - distance) / Radius;
        }
    }
}
