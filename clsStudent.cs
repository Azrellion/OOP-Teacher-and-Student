using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPClassTest2
{
    class clsStudent:clsPerson
    {
        private string Address;
        private string Postcode;
        private string Housenumber;        
        clsMenu menu = new clsMenu();
        clsPerson Prsn = new clsPerson();

        public clsStudent()
        {
            Address = "XXX";
            Postcode = "XXX XXX";
            Housenumber = "XX";
        }

        public void EnterDetails()
        {
            Prsn.Details();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter Students Address:");
            Console.SetCursorPosition(34, 5);
            Address = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter Students Postcode:");
            Console.SetCursorPosition(34, 5);
            Postcode = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter Students Housenumber:");
            Console.SetCursorPosition(38, 5);
            Housenumber = Console.ReadLine();
            Console.Clear();

           
            
        }


        public void PrintName()
        {
            Console.SetCursorPosition(0, 3);
            Prsn.Display();
            Console.WriteLine("Student address is: {0}", Address);
            Console.WriteLine("Student Postcode is: {0}", Postcode);
            Console.WriteLine("Student Housenumber is: {0}", Housenumber);
            Console.ReadKey();
            Console.Clear();
            
        }
        public void Name(int column, int row)
        {
            Console.SetCursorPosition(column, row);
            Console.WriteLine("First Name: {0}", FName);
            Console.SetCursorPosition(column+25, row);
            Console.WriteLine("Surname: {0}", SName);
        }
    }
        
    }



