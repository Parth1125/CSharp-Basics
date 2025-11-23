public class Vehicle
{
    public string Brand {get;set;}
    public int Speed {get;set;}
    public void start()
    {
        Console.WriteLine($"You {Brand} has Started");
    }
}
public class Car:Vehicle
{
    public void honk()
    {
        Console.WriteLine("Honking");
    }
}