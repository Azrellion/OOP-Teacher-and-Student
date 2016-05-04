using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPClassTest2
{
    class Program
    {
        static clsMenu menu = new clsMenu();

        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 30);
            menu.theMenu();
        }
    }
}
