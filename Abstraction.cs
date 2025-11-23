public abstract class Payment
{
    public abstract void pay();
    public void showMessage()
    {
        Console.WriteLine("Processing Payment");
    }
}

public class UPIPayment:Payment
{
    public override void pay()
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