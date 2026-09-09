#region Q1
//using System;
//class book
//{
//    private string password = "secret";

//}

//class program
//{
//    static void main()
//    {
//        Book book = new Book ();
//        Console.WriteLine (book.password);
//    }
//}
#endregion

#region Q2
//class Book {
//    internal int copiesInstock = 5;
// }
//class program
//{
//    static void Main()
//    {
//        Book book = new Book();
//        Console.WriteLine(book.copiesInstock);
//    }
//}
#endregion

#region Q3
//using System.Reflection;

//class Book
//{
//    public string Title;
//}
//class program
//{
//    static void Main()
//    {
//        Book book = new Book();
//        book.Title = "Barbie";
//    }
//}
#endregion

#region Q4
//using System;

//enum Genre
//{
//    Fiction,
//    NonFiction,
//    Science
//}

//class Book
//{
//    public Genre Genre;
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book();

//        book.Genre = Genre.Science;

//        Console.WriteLine(book.Genre);
//    }
//}
#endregion

#region Q5
//using System;
//enum Genre
//{
//    Fiction,
//    NonFiction,
//    Science
//}
//class Book
//{
//    public Genre Genre;
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine((int)Genre.Fiction);
//        Console.WriteLine((int)Genre.NonFiction);
//        Console.WriteLine((int)Genre.Science);
//    }
//}
#endregion

#region Q6
//using System;
//enum Genre
//{
//    Fiction,
//    NonFiction,
//    Science
//}
//class Program
//{
//    static void Main()
//    {
//        int genreNumber = 1;

//        Genre genre = (Genre)genreNumber;

//        Console.WriteLine(genre);
//    }
//}
#endregion