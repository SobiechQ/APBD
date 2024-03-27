namespace ConsoleApp1;

public class CoolingContainer:Container
{
    private readonly Dictionary<string, double> _productsToTemperature = new()
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };

    private string? _product;
    public string? Product
    {
        get => this._product;
        set
        {
            if (_product != null && this.ContentMass != 0 && _product.Equals(value))
            {
                throw new ArgumentException("Unable to set new product for non empty container");
            }

            if (value != null && !_productsToTemperature.ContainsKey(value))
            {
                throw new ArgumentException("No such product in database");
            }

            this._product = value;
        }
    }

    private int _temperature;
    public int Temperature
    {
        get
        {
            return this._temperature;
        }
        set
        {
            if (Product != null && value < this._productsToTemperature[Product])
            {
                throw new ArgumentException("Temperature too low for current product");
            }
        }
    }


    protected override char ContainerType()
    {
        return 'C';
    }

    protected override double BaseCapacity()
    {
        return 1000;
    }
}