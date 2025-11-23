public abstract class Payment//creating abstract class
{
    public abstract void pay();//creating abstract method
    public void showMessage()
    {
        Console.WriteLine("Processing Payment");
    }
}

public class UPIPayment:Payment
{
    public override void pay()// OVerriding Abstract method
    {
        Console.WriteLine("UPI Payment Done");
    }
    
}

public class CardPayment:Payment
{
    public override void pay()
    {
        Console.WriteLine("Card Payment Done");
    }
}