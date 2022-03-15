using System.Collections;
public class Agency : IEnumerable
{
    public Car[] Cars { get; set; }

    public IEnumerator GetEnumerator()
    {
        IEnumerator enumerator = Cars.GetEnumerator();
        while (enumerator.MoveNext())
            yield return enumerator.Current;
    }
    public Car[] GetCars(int modelYear)
    {
        return Cars.Where(thisCar => thisCar.ModelYear == modelYear).ToArray();
    }
    // public IEnumerable<Car> GetCars(int modelYear)
    // {
    //     foreach (var car in Cars)
    //     {
    //         if (car.ModelYear == modelYear)
    //             yield return car;
    //     }
    // }    
    public Car[] GetCars(string maker)
    {
        return Cars.Where(thisCar => thisCar.Maker == maker).ToArray();
    }
    // public IEnumerable<Car> GetCars(string maker)
    // {
    //     foreach (var car in Cars)
    //     {
    //         if (car.Maker == maker)
    //             yield return car;
    //     }
    // }
}