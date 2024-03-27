namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; set; }
    

    protected override char ContainerType()
    {
        return 'L';
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
            if (value >= BaseCapacity() * (IsHazardous?0.5 : 0.9))
            {
                throw new OverfillException(((IHazardNotifier)this).Notify());
            }
        }
    }
}