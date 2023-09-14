using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using H1_OOP_Library.Model;
using H1_OOP_Library.View;

namespace H1_OOP_Library.Controller
{
    public class BorrowSystem
    {

        public void Start()
        {
            // Create an instance of Library
            Library library = new Library();

            //Generate new books:
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "9780743273565");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, "9780061120084");
            Book book3 = new Book("1984", "George Orwell", 1949, "9780451524935");
            Book book4 = new Book("Pride and Prejudice", "Jane Austen", 1813, "9780141439518");
            Book book5 = new Book("The Catcher in the Rye", "J.D. Salinger", 1951, "9780316769488");
            Book book6 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, "9780345339683");
            Book book7 = new Book("To the Lighthouse", "Virginia Woolf", 1927, "9780156030472");
            Book book8 = new Book("Moby-Dick", "Herman Melville", 1851, "9780142437247");
            Book book9 = new Book("Brave New World", "Aldous Huxley", 1932, "9780060850524");
            Book book10 = new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954, "9780618640157");
            Book book11 = new Book("test1", "J.R.R. Tolkien", 1954, "9780618640157");
            Book book12 = new Book("test2", "J.R.R. Tolkien", 1954, "9780618640157");
            Book book13 = new Book("test3", "J.R.R. Tolkien", 1954, "9780618640157");

            //Add books to LendingList and inform the adding
            Display.Print(library.PopulateLendingList(book1));
            Display.Print(library.PopulateLendingList(book2));
            Display.Print(library.PopulateLendingList(book3));
            Display.Print(library.PopulateLendingList(book4));
            Display.Print(library.PopulateLendingList(book5));
            Display.Print(library.PopulateLendingList(book6));
            Display.Print(library.PopulateLendingList(book7));
            Display.Print(library.PopulateLendingList(book8));
            Display.Print(library.PopulateLendingList(book9));
            Display.Print(library.PopulateLendingList(book10));
            Display.Print(library.PopulateLendingList(book11));
            Display.Print(library.PopulateLendingList(book12));
            Display.Print(library.PopulateLendingList(book13));

            // retrieve a book by name, add to loan and remove from lending list
            Display.Print(library.RetrieveABookByName("test1"));
            Display.Print(library.RetrieveABookByName("test2"));
            Display.Print(library.RetrieveABookByName("test3"));

            //See the latest loan:
            Display.Print(library.ShowLatestLoanBook());

            //Delete the latest loan:
            Display.Print(library.DeleteLatestLoanBook());
        }

    }
}
