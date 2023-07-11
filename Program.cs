using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotoexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            again:
            Console.WriteLine("Enter user name");
            username = Console.ReadLine();
            if(username.Length >=6) {
                Console.WriteLine("Welcome  " + username);
            }
            else
            {
                Console.WriteLine("inavalid username");
                goto again;
            }
            Console.ReadKey();
        }
    }
}
