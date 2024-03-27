namespace ConsoleApp1;

public interface IHazardNotifier
{
    public string IHazardNotifierName();

    public string Notify()
    {
        return "Hazardous maneuver for container: [" + IHazardNotifierName() + "]";
    }
}