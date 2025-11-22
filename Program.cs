public class Greeter {
   

    public static void Main() {
        BankAccount accountBalance = new BankAccount();
        Student studentMarks = new Student();

        studentMarks.marksGiven(30);
        studentMarks.marksGiven(20);
        Console.WriteLine($"Your total marks is {studentMarks.Marks}");
        // accountBalance.Deposit(100);
        // Console.WriteLine(accountBalance.Balance);
        // accountBalance.Deposit(500);
        //    Console.WriteLine(accountBalance.Balance);
    }
}