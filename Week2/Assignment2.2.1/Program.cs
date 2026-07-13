public class Vehicle 
{
    public string Make { get; set; }
    public string WheelsNum { get; set; }
    public int Mileage { get; set; }

    public void Drive()
    {
        Console.WriteLine("Vehicle is driving.");
    }

    public void Break()
    {
        Console.WriteLine("Vehicle is braking.");
    }

    public virtual void Beep()
    {
        Console.WriteLine("Vehicle is beeping.");
    }
}