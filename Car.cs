public class Car
{
    int modelYear;
    public int ModelYear
    {
        get
        {
            return modelYear;
        }
        set
        {
            if (value < 1900)
                throw new ArgumentOutOfRangeException("Value must be above 1900");
            modelYear = value;
        }
    }
    public string Maker { get; set; }
    public override string ToString()
    {
        return $"{ModelYear}, {Maker}";
    }
}