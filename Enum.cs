using System;


// public class Greeter {
 
   
    
//     public static void Main() {
//         Order o = new Order(100,Status.Open);
//        o.updateStatus(Status.Closed);
//     }
// }
public class Order{
    public int Id{get;set;}
    public Status OrderStatus{get;set;}
    public Order(int id, Status statusparam)
    {
        Id = id;
        OrderStatus = statusparam;
    }
    public void updateStatus(Status statusparam)
    {
     OrderStatus = statusparam;
     Console.WriteLine($"Your status is {OrderStatus}"); 
    }      
    }
public enum Status
{
    Open,
    Closed,
    Pending,
    Submitted,
}