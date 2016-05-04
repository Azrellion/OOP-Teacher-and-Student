using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPClassTest2
{
    class clsMenu

    {
        private string Choice;
        static clsTeacher teach = new clsTeacher();
        static clsStudent stdnt = new clsStudent();
        static clsEmployee Comp = new clsEmployee();
        static clsTemplate bord = new clsTemplate();
        static clsMatch match = new clsMatch();


        public clsMenu()
        {
            Choice = "xxxx";
        }

        public void theMenu()
        {
            do
            {
                Options();
                
            } while (Choice != "10");
        }


        private void Options()
        {

            int row = 2;

            bord.Border();
            Console.Title = "Work Placement System";

            Console.SetCursorPosition(3, row++);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Work Experience Match System, Please enter the number for the page you would like to view");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(3, row=row+2);
            Console.WriteLine("1.   |   Help");
            Console.SetCursorPosition(3, row=row+1);
            Console.WriteLine("2.   |   Enter Student Details");
            Console.SetCursorPosition(3, row = row+1);
            Console.WriteLine("3.   |   Enter Teacher Details");
            Console.SetCursorPosition(3, row = row + 1);
            Console.WriteLine("4.   |   Enter Company Details");
            Console.SetCursorPosition(3, row = row + 1);
            Console.WriteLine("5.   |   View Student Details");
            Console.SetCursorPosition(3, row = row + 1);
            Console.WriteLine("6.   |   View Teacher Details");
            Console.SetCursorPosition(3, row = row + 1);
            Console.WriteLine("7.   |   View Company Details");
            Console.SetCursorPosition(3, row = row + 1);
            Console.WriteLine("8.   |   Match Student with Company & Setup Interview Time");
            Console.SetCursorPosition(3, row = row + 1);
            Console.WriteLine("9.   |   View Interview Details");
            Console.SetCursorPosition(3, row = row + 1);
            Console.WriteLine("10.  |   Exit Program");
            Console.SetCursorPosition(3, row = row + 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Enter a choice from the list above to go to the page:");
            Console.SetCursorPosition(64, row);
            Choice = Console.ReadLine();
            



            switch (Choice)
            {
                case "1":
                    
                    break;
                case "2":
                    Console.Clear();
                    match.EnterDetailsA();
                    break;
                case "3":
                    Console.Clear();
                    teach.TeacherEnterDetails();
                    break;
                case "4":
                    Console.Clear();
                    match.EnterCompDet();
                    break;
                case "5":
                    Console.Clear();
                    match.ViewStudent();
                    break;
                case "6":
                    Console.Clear();
                    teach.TeacherDisplayDetails();
                    break;
                case "7":
                    Console.Clear();
                    match.ViewCompany();
                    break;
                case "8":
                    Console.Clear();
                    match.MatchStuComp();
                    break;
                case "10":
                    Console.Clear();
                    //Comp.Emp_DisplayDetails();
                    Console.WriteLine("about to exit");
                    
                 break;


            }

        }
    }
}
