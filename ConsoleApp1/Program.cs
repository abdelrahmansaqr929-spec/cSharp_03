namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer_01
            int pages = 464;
            bool isAvailable = true;
            if (isAvailable && pages > 300)
            {
                Console.WriteLine("you can borrow this book ");
            }

            #endregion
            #region answer_02
            string title = "Refactoring";
            switch (title)
            {
                case "Clean code":
                    Console.WriteLine("Great choice");
                    break;
                case "Refactoring":
                    Console.WriteLine("nice pick");
                    break;
                default:
                    Console.WriteLine("not hared of it ");
                    break;
            }
            #endregion
            #region answer_03
            string sizeLabkle =
            pages > 300 ? sizeLabkle = "Long Book" : sizeLabkle = "Short Book";
            Console.WriteLine(sizeLabkle);
            #endregion
            #region answer_04
            string[] books = { "Clean code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($" {i+1}.{books[i]}");
            }

            #endregion




        }
    }
}
