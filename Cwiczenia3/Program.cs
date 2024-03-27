// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

var containers = new List<Container>();
var c1 = new CoolingContainer();

var ship = new Ship(30, 5, 5000);

var coolingContainer1 = new CoolingContainer
{
    OwnMass = 100,
    ContentMass = 200,
    Product = "Bananas",
    Temperature = 15
};

var coolingContainer2 = new CoolingContainer
{
    OwnMass = 150,
    ContentMass = 250,
    Product = "Fish",
    Temperature = 5
};
var gasContainer = new GasContainer()
{
    OwnMass = 150,
    ContentMass = 250,
};
var liquidContainer = new LiquidContainer()
{
    OwnMass = 150,
    ContentMass = 250,
    IsHazardous = true
};
Console.WriteLine(coolingContainer1.TotalMass());
Console.WriteLine(coolingContainer2.TotalMass());

ship.AddContainer(coolingContainer1);
ship.AddContainer(coolingContainer2);
ship.AddContainer(gasContainer);
ship.AddContainer(liquidContainer);
try
{
    coolingContainer1.Temperature = 0;
}
catch (Exception e)
{
    Console.WriteLine(e); //nie uda się ponieważ temperatura jest za niska dla produktu
}

try
{
    liquidContainer.ContentMass = 510;
}
catch (Exception e)
{
    Console.WriteLine(e); // nie uda się ponieważ przekroczono pojemność dla materiału niebezpiecznego
}
Console.WriteLine("Total mass of all containers on the ship: " + ship.Containers.Sum(c => c.TotalMass()));