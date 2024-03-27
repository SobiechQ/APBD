namespace ConsoleApp1;

public abstract class Container
{
    private static int _containerCount = 0;

    public string SerialNumber => "KON" + this.ContainerType() + _containerCount++;

    private double _contentMass = 0;
    public virtual double ContentMass
    {
        get => this._contentMass;
        set
        {
            if (value >= this.BaseCapacity())
            {
                throw new OverfillException("Content mass overfills base capacity");
            }

            this._contentMass = value;
        }
    }

    public double TotalMass()
    {
        return OwnMass + ContentMass;
    }

    public double OwnMass { get; set; }
    public double Height { get; set; }


    protected abstract char ContainerType();
    protected abstract double BaseCapacity();
    
    
}