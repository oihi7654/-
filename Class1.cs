using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        readonly Hashtable _books;

        public Class1()
        {
            _books = new Hashtable();
        }
        public void AddBook(Book book)
        {
            _books.Add(book.Author, book);
        }
        public void AddBooks(IEnumerable<Book> books)
        {
            foreach (var book in books)
                AddBook(book);
        }
        public void RemoveBook(Book book)
        {
            _books.Remove(book.Author);
        }
        public void RemoveBooks(IEnumerable<Book> books)
        {
        foreach (var book in books)
            RemoveBook(book);
        }
        public IEnumerable<Book> SortedBooksByAuthors()
        {
            return _books.Values.OfType<Book>().OrderBy(b =>b.Author);
        }
        public IEnumerable<Book> SortedBooksByYear()
        {
            return _books.Values.OfType<Book> ().OrderBy(b =>b.Year);
        }
    }
}
    public class Book
    {
        public Book(string author, string name, int year, int count)
        {
            Author = author;
            Name = name;
            Year = year;
            Count = count;
        }

        public string Author { get; private set; }
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Count { get; private set; }

        public override string ToString()
        {
            return string.Format(" Author: {0}\tName: {1}\t Year:{ 2}\t Count: {3}", Author, Name, Year, Count);
        }
    }

