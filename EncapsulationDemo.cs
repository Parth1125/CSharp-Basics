using System;

// public class Greeter {
   

//     public static void Main() {
//         BankAccount accountBalance = new BankAccount();
//         accountBalance.Deposit(100);
//         Console.WriteLine(accountBalance.Balance);
//         accountBalance.Deposit(500);
//            Console.WriteLine(accountBalance.Balance);
//     }
// }

public class BankAccount
{
    private int balance;
    
    public int Balance
    {
        get{return balance;}
        private set {balance = value;}
    }
    public void Deposit(int amount)
    {
        balance += amount;
        Console.WriteLine($"Amount Deposited {amount}");
    }
}

public class Student
{
    private int marks=0;
    public int Marks
    {
        get{return marks;}
        private set{marks = value;}

    }
    public void marksGiven(int mark)
    {
        if(mark > 0)
        {
            
        marks+=mark;
        Console.WriteLine($"You have been given this {mark}");
        }
    }
}