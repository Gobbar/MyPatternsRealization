// See https://aka.ms/new-console-template for more information
using Patterns.AbstractFactory;
using Patterns.Adapter;
using Patterns.Decorator;
using Patterns.DI_IoC;
using Patterns.Factory;
using Patterns.Mediator;
using Patterns.Observer;

ObserverTest.MyButtonTest();
Console.WriteLine("---");
ObserverTest.NETButtonTest();
Console.WriteLine("------\n");

Console.WriteLine("------");
Console.WriteLine("AbstractFactory");
Console.WriteLine("------");
var rand = new Random();
Console.WriteLine("Iron");
AbstractFactoryTest.ArmorFactoryTest(new IronArmorFactory(rand));
Console.WriteLine("Steel");
AbstractFactoryTest.ArmorFactoryTest(new SteelArmorFactory(rand));

Console.WriteLine("------");
Console.WriteLine("FactoryMethod");
Console.WriteLine("------");
FactoryTest.CreatureFactoryTest(new ZombiFactory(rand));
FactoryTest.CreatureFactoryTest(new BanditFactory(rand));

Console.WriteLine("------");
Console.WriteLine("RangeAdapter");
Console.WriteLine("------");
AdapterTest.RangeAdapterTest();

Console.WriteLine("------");
Console.WriteLine("Mediator");
Console.WriteLine("------");
MediatorTest.Test();

Console.WriteLine("------");
Console.WriteLine("DI");
Console.WriteLine("------");
DITest.Test();

Console.WriteLine("------");
Console.WriteLine("Decorator");
Console.WriteLine("------");
DecoratorTest.Test();
