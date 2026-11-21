using System.Drawing;
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

            //string title = "clean code";
            //string newTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(newTitle);

            #endregion

            #region Question 2
            // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.

            string s1 = "Clean Code";
            string s2 = "Clean Code";

            Console.WriteLine(ReferenceEquals(s1,s2));  // True

            #endregion
        }
    }
}
