using System;

namespace Pr1;

class Program
{
    static void Main() 
    {
        // Book b1 = new Book();
       Book b2 = new Book("Tolstoy", "War and Peace", "Scince and life", 1234, 2013, 101);
        // Book b3 = new Book("Lermontov", "Mciri");

        Item it;

        it = b2;

        Console.WriteLine("Polimorphism test:");
        it.TakeItem();
        it.Return();
        it.Show();



        // b1.SetBook("Pushkin", "Captain's daughter", "Williams", 123, 2014);
        // Book.SetPrice(12);
        // b2.TakeItem();
        // b2.Show();

        // TestClassBook(b1);
        // TestClassBook(b2);
        // TestClassBook(b3);

        Magazine mag1 = new Magazine("Nature", 5, "We and Earth", 2014, 1235);
        // mag1.Show();

        it = mag1;
        it.TakeItem();
        it.Return();
        it.Show();
    }

    // static void TestClassBook(Book book)
    // {
    //     book.Show();
    //     Console.WriteLine($"\nNumber of rental days for {book.GetTitle()}");
    //     int rentDays = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine($"\nRent {book.GetTitle()} for {rentDays} days will cost: {book.PriceBook(rentDays)}");
    // }
}