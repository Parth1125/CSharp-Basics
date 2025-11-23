public class Greeter {
   

    public static void Main() {
        BankAccount accountBalance = new BankAccount();
        Student studentMarks = new Student();
        Payment UPIPayment1 = new  UPIPayment();
        Payment CardPayment1 = new CardPayment();

        UPIPayment1.pay();
        UPIPayment1.showMessage();
        CardPayment1.pay();
        CardPayment1.showMessage();

        // accountBalance.Deposit(100);
        // Console.WriteLine(accountBalance.Balance);
        // accountBalance.Deposit(500);
        //    Console.WriteLine(accountBalance.Balance);
    }
}