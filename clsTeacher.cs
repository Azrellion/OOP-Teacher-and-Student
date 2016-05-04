using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPClassTest2
{
    class clsTeacher:clsEmployee
    {
        private string StaffNo;
        private string Subject;
        private string Department;
        clsMenu menu = new clsMenu();

        public clsTeacher()
        {
            StaffNo = "0000";
            Subject = "XXXX XXXX";
            Department = "XX";
        }

        public void TeacherEnterDetails()
        {

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please Enter your Staff Number:");
            Console.SetCursorPosition(34, 5);
            StaffNo = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please Enter your Subject:");
            Console.SetCursorPosition(30, 5);
            Subject = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please Enter your Department:");
            Console.SetCursorPosition(32, 5);
            Department = Console.ReadLine();
            Console.Clear();
           
        }

        public void TeacherDisplayDetails()
        {
            //Console.SetCursorPosition(0, 3);
            Emp_DisplayDetails();
            Console.WriteLine("Your Staff Number is: {0}", StaffNo);
            Console.WriteLine("Your Subject is: {0}", Subject);
            Console.WriteLine("Your Department is: {0}", Department);
            Console.ReadKey();
        }

    }
}

