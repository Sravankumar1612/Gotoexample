using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotoexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example1
           /* string username;
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
           */

            //Example2
           /* for (int i = 0; i < 10; i++) {
                if (i == 6)
                {
                    goto ending;
                }
                Console.WriteLine("i value"+i);
            }
        ending: Console.WriteLine("The End");
            Console.ReadKey();  
           */

            //timespan example
            DateTime dt=new DateTime(day: 13,month:07,year:2023);
            DateTime dateTime = DateTime.Now;
            TimeSpan timeSpan = dt.Subtract(dateTime);
            Console.WriteLine("Days remain " + timeSpan.Days);
            Console.ReadKey();
        }
    }
}
