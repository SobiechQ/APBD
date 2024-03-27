namespace ConsoleApp1;

public class GasContainer:Container, IHazardNotifier
{
    protected override char ContainerType()
    {
        return 'G';
    }

    protected override double BaseCapacity()
    {
        return 1000;
    }

    public string IHazardNotifierName()
    {
        return this.SerialNumber;
    }
    public override double ContentMass
    {
        set
        {
            if (value <= BaseCapacity()*0.1)
            {
                throw new OverfillException(((IHazardNotifier)this).Notify());
            }
        }
    }
}