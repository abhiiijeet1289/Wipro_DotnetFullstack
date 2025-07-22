using System;

namespace StructExample
{
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public short Year;
    }

    enum DaysOfWeek
    {
        Monday, Tuesday, Wednesday
    }

    enum Status
    {
        Pending,
        Approved,
        Rejected
    }

    class BookStructure
    {
        static void Main(string[] arfs)
        {
            DaysOfWeek t1 = DaysOfWeek.Tuesday;
            Console.WriteLine("Structure Example");

            // Creating a struct object
            Book myBook = new Book();
            myBook.Title = "CSharp";
            myBook.Author = "ABC";
            myBook.Price = 4545.00M;
            myBook.Year = 2017;

            Console.WriteLine("Book Info: " + myBook.Title + ", " + myBook.Author + ", " + myBook.Price + ", " + myBook.Year);

            // Using enum in if condition
            if (t1 == DaysOfWeek.Monday || t1 == DaysOfWeek.Tuesday)
            {
                Console.WriteLine("Either it is Monday or Tuesday");
            }
            else
            {
                Console.WriteLine("It's not Monday or Tuesday");
            }

            // Switch case on enum
            switch (t1)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("It's Monday");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("It's Tuesday");
                    break;
                case DaysOfWeek.Wednesday:
                    Console.WriteLine("It's Wednesday");
                    break;
                default:
                    Console.WriteLine("It's Weekend");
                    break;
            }

            // Enum to string
            Status s = Status.Pending;
            string statusString = s.ToString();
            Console.WriteLine("Current status is: " + statusString);
        }
    }
}
