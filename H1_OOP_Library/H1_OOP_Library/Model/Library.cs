using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H1_OOP_Library.Model
{
    public class Library
    {
        #region Attributes
        private List<Book> _lendingList;
        private Stack<Book> _userLoan;
        #endregion

        #region Properties  
        public List<Book> LendingList { get => _lendingList; set => _lendingList = value; }
        public Stack<Book> UserLoan { get => _userLoan; set => _userLoan = value; }


        #endregion

        #region Constructors  
        /// <summary>
        /// Construct a library
        /// generates a list for lendingBooks, and a stack for userLoan
        /// </summary>
        public Library()
        {
            LendingList = new List<Book>();
            UserLoan = new Stack<Book>();
        }

        //public Library(List<Book> lendingList): this()
        //{
        //    LendingList = lendingList;
        //}
        //public Library(List<Book> lendingList, Stack<Book> userLoan): this(lendingList)
        //{
        //    UserLoan = userLoan;
        //}

        #endregion
        /// <summary>
        /// this method add a book into the lending list, then return a 
        /// success message with info of the book.
        /// </summary>
        public string PopulateLendingList(Book book)
        {
            LendingList.Add(book);
            return $"Added a book to the Lending List! \nBook Info:\n{book}";
        }




        /// <summary>
        /// Retrieve a book by name
        /// if book is found in the lending list
        /// if not, generate a no found msg
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string RetrieveABookByName(string name)
        {
            if (LendingList.Count == 0)
            {
                return "Lending list is empty now!";
            }
            else
            {
                Book retrievedBook = LendingList.FirstOrDefault(book => book.Name == name);
                if (retrievedBook != null)
                {
                    AddBookToUserLoan(retrievedBook);
                    DeleteBookFromLendingList(retrievedBook);
                    return $"\n\"{retrievedBook.Name}\" is added to user loan and removed from Lending List.";
                    
                }
                return "Book Not Found";
            }
        }
        /// <summary>
        /// only use when a retrieving is successful
        /// </summary>
        /// <param name="book"></param>
        public void AddBookToUserLoan(Book book)
        {
            UserLoan.Push(book);
        }

        /// <summary>
        /// Delete a book from lending list and generate a message
        /// only use when a retrieving and adding to UserLoan is successful
        /// </summary>
        /// <param name="book"></param>
        public void DeleteBookFromLendingList(Book book)
        {
            LendingList.Remove(book);
        }


        /// <summary>
        /// Use Peek method to check the latest book in user loan
        /// if user loan is empty, generate an error message
        /// </summary>
        /// <returns></returns>
        public string ShowLatestLoanBook()
        {
            try
            {
                Book latestBook = UserLoan.Peek();
                return $"Your latest book to borrow is \"{latestBook.Name}\".";
            }
            catch
            {
                return "Your loan is empty now.";
            }
        }
        /// <summary>
        /// Use POP method to delete the latest book from the stack
        /// if user loan is empty, generate an error message
        /// </summary>
        /// <returns></returns>
        public string DeleteLatestLoanBook()
        {
            try
            {
                Book latestBook = UserLoan.Pop();
                return $"\"{latestBook.Name}\" has been removed from our loan.";
            }
            catch
            {
                return "Your loan is empty now.";
            }
        }

    }
}
