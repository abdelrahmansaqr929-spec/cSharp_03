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
            #region answer_05
            int j= 0;
            while (j < books.Length)
            {
                Console.WriteLine(books[j]);
                j++;
            }
            #endregion
            #region answer_06
            int l = 0;
            do { Console.WriteLine("checking book"); l++ ; }
            while (l < 3);

            #endregion
            #region answer_07
            foreach (string book in books)
                { Console.WriteLine(book); }
            #endregion
            #region answer_08
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
                if (books[i] == "Refactoring")
                break;
                
            }
            #endregion
            #region answer_09
            for (int i =0; i<books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine(books[i]);
            }
#endregion



        }
    }
}
