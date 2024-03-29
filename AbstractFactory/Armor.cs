using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public interface IHelmet
    {
        int Protection { get; }
    }

    public interface IChestplate
    {
        int Protection { get; }
    }

    public interface IBoot
    {
        int Protection { get; }
    }

    public class IronHelmet : IHelmet
    {
        private readonly int _protection;
        public int Protection { get => _protection; }

        public IronHelmet(int protection)
        {
            _protection = protection;
        }
    }

    public class IronChestplate : IChestplate
    {
        private readonly int _protection;
        public int Protection { get => _protection; }

        public IronChestplate(int protection)
        {
            _protection = protection;
        }

    }

    public class IronBoot : IBoot
    {
        private readonly int _protection;
        public int Protection { get => _protection; }

        public IronBoot(int protection)
        {
            _protection = protection;
        }
    }

    public class SteelHelmet : IHelmet
    {
        private readonly int _protection;
        public int Protection { get => _protection; }

        public SteelHelmet(int protection)
        {
            _protection = protection;
        }
    }

    public class SteelChestplate : IChestplate
    {
        private readonly int _protection;
        public int Protection { get => _protection; }

        public SteelChestplate(int protection)
        {
            _protection = protection;
        }

    }

    public class SteelBoot : IBoot
    {
        private readonly int _protection;
        public int Protection { get => _protection; }

        public SteelBoot(int protection)
        {
            _protection = protection;
        }
    }
}
