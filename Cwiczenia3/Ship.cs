namespace ConsoleApp1;

public class Ship
{
    public List<Container> Containers {internal set; get; } = [];

    public double MaxSpeed;
    public int MaxContainerCount;
    public int MaxContainersMass;

    public Ship(double maxSpeed, int maxContainerCount, int maxContainersMass)
    {
        MaxSpeed = maxSpeed;
        MaxContainerCount = maxContainerCount;
        MaxContainersMass = maxContainersMass;
    }

    public void AddContainer(Container container)
    {
        if (Containers.Count >= MaxContainerCount || Containers.Select(i => i.TotalMass()).Sum() >= MaxContainersMass)
        {
            
            throw new OverfillException("Container not added. Surpassed maximum capacity" + MaxContainerCount+", " + Containers.Count() + ", " + MaxContainersMass + ", " + Containers.Select(i => i.TotalMass()).Sum());
        }
        Containers.Add(container);
    }

    public void AddContainer(IEnumerable<Container> container)
    {
        foreach (var c in container)
        {
            AddContainer(c);
        }
    }

    public void RemoveContainer(String code)
    {
        Containers.Remove(FindContainerByCode(code));
    }

    private Container? FindContainerByCode(String code)
    {
        return Containers.Find(c => c.SerialNumber.Equals(code));
    }

    private void Empty()
    {
        Containers = [];
    }
}