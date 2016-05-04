using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPClassTest2
{
    class clsMatch : clsStudent
    {
        private static clsStudent[] Stdt = new clsStudent[2];
        private static clsEmployee[] Emp = new clsEmployee[2];
        private static string interview;
        private static string hour;
        private static string min;
        private static string day;
        private static string month;
        private static string year;
        private static string stu;
        private static string com;

        public void EnterDetailsA()
        {
            Console.Clear();
            for (int rec = 0; rec < 2; rec++)
            {
                Stdt[rec] = new clsStudent();
                Stdt[rec].EnterDetails();

                Console.Clear();
            }
        }

        public void EnterCompDet()
        {
            Console.Clear();
            for (int rec = 0; rec < 2; rec++)
            {
                Emp[rec] = new clsEmployee();
                Emp[rec].Emp_EnterDetails();

                Console.Clear();
            }
        }
        public void ViewStudent()
        {
            Console.Clear();

            for (int rec = 0; rec < 2; rec++)
            {
                Stdt[rec].PrintName();
            }

            Console.Clear();
        }
        public void ViewCompany()
        {
            Console.Clear();

            for (int rec = 0; rec < 2; rec++)
            {
                Emp[rec].Emp_DisplayDetails();
            }
            Console.Clear();
        }

        public void MatchStuComp()
        {
            int StuNo, CompNo;

            Console.Clear();
            Console.WriteLine("Please Enter the Students Number");
            StuNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the Company Number");
            Console.WriteLine("The Student Number and Company Number will then be matched together.");
            CompNo = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.SetCursorPosition(25,5);
            Console.WriteLine("Matching Records");
            Console.SetCursorPosition(25,6);
            Console.WriteLine("----------------");

            Console.SetCursorPosition(4,8);
            Console.Write ("Student Firstname ");
            Console.SetCursorPosition(4 + 25, 8);
            Console.Write("| Student Surname");

            Console.SetCursorPosition(4 + 60, 8);
            Console.Write("Company Name ");
            Console.SetCursorPosition(4 + 80, 8);
            Console.Write("| Contact Number");

            Stdt[StuNo].Name(4,10);
            Emp[CompNo].Emp_Name(4 + 50, 10);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("               Would you like to setup an interview? y/n?");

            interview = Console.ReadLine();

            if(interview == "yes" || interview == "y")
            {
                Console.WriteLine("Please enter a Time and Date");
                Console.WriteLine("HH:MM      DD/MM/YYYY");

                Console.SetCursorPosition(0, 15);
                hour = Console.ReadLine();
                Console.SetCursorPosition(3, 15);
                min = Console.ReadLine();
                Console.SetCursorPosition(11, 15);
                day = Console.ReadLine();
                Console.SetCursorPosition(14, 15);
                month = Console.ReadLine();
                Console.SetCursorPosition(17, 15);
                year = Console.ReadLine();

                Console.WriteLine("Thank you your Interview has been set please select option 9 in the menu to view the interview details\n");
                Console.WriteLine("Press any key to continue");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}

