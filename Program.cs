using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            book.Addgrade(89.1);
            book.Addgrade(90.5);
            book.Addgrade(77.5);
            book.ShowStatistics();


        }
    }
}
