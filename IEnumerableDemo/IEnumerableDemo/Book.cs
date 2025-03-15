using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    public class Book
    {
        public string Title { get; set; }
    }
    
    public class Library
    {
        // Method that accepts any IEnumerable<string> and prints each title

        public void PrintBookTitles(IEnumerable<string> bookTitles)
        {
            foreach (string title in bookTitles)
            {
                Console.WriteLine(title);
            }
        }
    }

}
