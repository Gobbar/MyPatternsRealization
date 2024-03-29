using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    public interface ICreature
    {
        int Strength { get; }
        int Speed { get; }
        int Attack();
        int Move();
    }

    public class Zombi : ICreature
    {
        private int _strength;
        public int Strength { get => _strength; }

        private int _speed;
        public int Speed { get => _speed; }

        public Zombi(int strength, int speed)
        {
            _strength = strength;
            _speed = speed;
        }

        public int Attack()
        {
            return _strength;
        }

        public int Move()
        {
            return _speed;
        }
    }

    public class Bandit : ICreature
    {
        private int _strength;
        public int Strength { get => _strength; }

        private int _speed;
        public int Speed { get => _speed; }

        private int _weaponId;

        public Bandit(int strength, int speed, int weaponId)
        {
            _strength = strength;
            _speed = speed;
            _weaponId = weaponId;
        }

        public int Attack()
        {
            return _weaponId * _strength;
        }

        public int Move()
        {
            return _speed;
        }
    }
}
