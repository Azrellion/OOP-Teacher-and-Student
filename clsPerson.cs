using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPClassTest2
{
    class clsPerson
    {

        public string FName;
        public string SName;
        public string ContactNo;
        public string ContactEmail;


        public clsPerson()
        {
            FName = "XXXX";
            SName = "XXXX";
            ContactNo = "0000";
            ContactEmail = "XXXX";
        }

        public void Details()
        {
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter A First Name:");
            Console.SetCursorPosition(38, 5);
            FName = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter A Last Name:");
            Console.SetCursorPosition(36, 5);
            SName = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter A Contact Number:");
            Console.SetCursorPosition(38, 5);
            ContactNo = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter A Email Address:");
            Console.SetCursorPosition(36, 5);
            ContactEmail = Console.ReadLine();
            Console.Clear();
        }

        public void Display()
        {
            Console.WriteLine("First Name is: {0}", FName);
            Console.WriteLine("Last Name is: {0}", SName);
            Console.WriteLine("Contact Number is: {0}", ContactNo);
            Console.WriteLine("Contact Email is: {0}", ContactEmail);
        }

    }
}

