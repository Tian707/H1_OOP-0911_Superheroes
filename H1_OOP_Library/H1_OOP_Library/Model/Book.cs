using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_Library.Model
{
    public class Book
    {
        #region Attributes
        private string _name;
        private string _isbn;
        private string _author;
        private ushort _year;
        #endregion

        #region Properties  
        public string Name { get => _name; private set => _name = value; }
        public string ISBN { get => _isbn; private set => _isbn = value; }
        public string Author { get => _author; private set => _author = value; }
        public ushort Year { get => _year; private set => _year = value; }

        #endregion

        #region Constructors  
        /// <summary>
        /// Construct a book
        /// </summary>
        public Book() { }
        public Book(string name, string author, ushort year, string isbn) : this()
        {
            Name = name;
            ISBN = isbn;
            Author = author;
            Year = year;
        }
        #endregion
        public override string ToString()
        {
            return $"Name: \"{Name}\", Author: {Author}, Year: {Year}, ISBN: {ISBN}";
        }
    }
}
