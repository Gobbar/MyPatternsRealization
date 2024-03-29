using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public interface IMelee
    {
        int Damage { get; }
        int Speed { get; }

        int Hit();
    }

    public class Melee : IMelee
    {
        private int _damage;
        public int Damage { get => _damage; }

        private int _speed;
        public int Speed { get => _speed; }

        public Melee(int damage, int speed)
        {
            _damage = damage;
            _speed = speed;
        }

        public int Hit()
        {
            return Damage * Speed; 
        }
    }
}
