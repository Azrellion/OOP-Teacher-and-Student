using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPClassTest2
{
    class clsEmployee : clsStudent
    {
        private string EmpName;
        private string EmpAddress;
        public string EmpContactNo;
        public string EmpContactEmail;
        

        public clsEmployee()
        {
            EmpName = "XXXX";
            EmpAddress = "XXXX";
            EmpContactNo = "0000";
            EmpContactEmail = "XXXX";
        }

        public void Emp_EnterDetails()
        {
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter The Company Name:");
            Console.SetCursorPosition(37, 5);
            EmpName = Console.ReadLine();
            Console.Clear();

           
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter The Company Address:");
            Console.SetCursorPosition(34, 5);
            EmpAddress = Console.ReadLine();
            Console.Clear();

            
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter A Contact Number:");
            Console.SetCursorPosition(37, 5);
            EmpContactNo = Console.ReadLine();
            Console.Clear();

            
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Please enter A Contact Email:");
            Console.SetCursorPosition(34, 5);
            EmpContactEmail = Console.ReadLine();
            Console.Clear();
        }

        public void Emp_DisplayDetails()
        {
            Console.WriteLine("The Company Name is: {0}", EmpName);
            Console.WriteLine("The Company Address is: {0}", EmpAddress);
            Console.WriteLine("The Contact Number for the company is: {0}", EmpContactNo);
            Console.WriteLine("The Contact Email for the company is: {0}", EmpContactEmail);
            Console.ReadKey();
            Console.Clear();
        }
        public void Emp_Name(int column, int row)
        {
            Console.SetCursorPosition(column, row);
            Console.WriteLine("Company Name: {0}", EmpName);
            Console.SetCursorPosition(column + 20, row);
            Console.WriteLine("Company Contact: {0}", EmpContactNo);
            
        }
    }
}
    

