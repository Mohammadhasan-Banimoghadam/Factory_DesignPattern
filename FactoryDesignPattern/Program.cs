
Console.WriteLine(RunMethod(new CreatorAirPlan()));
Console.WriteLine(RunMethod(new CreatorShip()));
Console.WriteLine(RunMethod(new CreatorTruck()));

string RunMethod(Creator creator)
{
    return creator.Operation();
}

abstract class Creator
{
    public abstract IVehicle FactoryMethod();

    public string Operation()
    {
        var vehicle = FactoryMethod();

        var result = "Creator: The same creator's code has just worked with " + vehicle.Deliver();

        return result;
    }
}

class CreatorTruck : Creator
{
    public override IVehicle FactoryMethod()
    {
        return new Truck();
    }
}

class CreatorShip : Creator
{
    public override IVehicle FactoryMethod()
    {
        return new Ship();
    }
}

class CreatorAirPlan : Creator
{
    public override IVehicle FactoryMethod()
    {
        return new AirPlan();
    }
}


public interface IVehicle
{
    string Deliver();
}

class Truck : IVehicle
{
    public string Deliver()
    {
        return "Deliver By Truck";
    }
}

class Ship : IVehicle
{
    public string Deliver()
    {
        return "Deliver By Ship";
    }
}

class AirPlan : IVehicle
{
    public string Deliver()
    {
        return "Deliver By AirPlan";
    }
}






