using System.Security.Cryptography;
using System.Threading.Channels;

namespace Session03Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            // both title and upperTitle to show that title did not change

            string title = "clean code";
            string newTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(newTitle);

            #endregion
        }
    }
}
