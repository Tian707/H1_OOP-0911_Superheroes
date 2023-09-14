using H1_OOP_Library.Controller;

namespace H1_OOP_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BorrowSystem borrowSys = new BorrowSystem();
            borrowSys.Start();
        }
    }
}