using System;

class Client
{
    private AbstractWater water;
    private AbstractBottle bottle;

    public Client(AbstractFactory factory)
    {
        water = factory.CreateWater();
        bottle = factory.CreateBottle();
    }

    public void Run()
    {
        bottle.Interact(water);
    }
}

abstract class AbstractFactory
{
    public abstract AbstractWater CreateWater();
    public abstract AbstractBottle CreateBottle();
}

class WaterFactory : AbstractFactory
{
    public override AbstractWater CreateWater()
    {
        return new SimpleWater();
    }

    public override AbstractBottle CreateBottle()
    {
        return new WaterBottle();
    }
}

abstract class AbstractWater { }

class SimpleWater : AbstractWater { }

abstract class AbstractBottle
{
    public abstract void Interact(AbstractWater water);
}

class WaterBottle : AbstractBottle
{
    public override void Interact(AbstractWater water)
    {
        Console.WriteLine("Interacting...");
    }
}


class Program
{
    static void Main()
    {
        Client client = null;
    }
}
