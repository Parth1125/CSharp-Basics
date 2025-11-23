public class Book
{
    public string Title {get;set;}
    public string Author {get;set;}
    public int Price {get;set;}

    public Book(string title,string author,int price)//defining constructor and setting values in it 
    {
        Title = title;
        Author= author;
        Price = price;
    }
    public void GetInfo()
    {
        Console.WriteLine($"Title is {Title} , author is {Author},Price is {Price}");
    }
}