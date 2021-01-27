using System;
using System.Collections.Generic;
using System.Text;

namespace Medium_1
{
    class EmployeePromotion : Employee
    {

        public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>();


        public void FindEmployeeByID()
        {
            int id = -1;
            try
            {
                Console.WriteLine("Please enter the employee ID : ");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ID should be a number ");
                FindEmployeeByID();
                return;
            }

            if (employees.ContainsKey(id))
            {
                Console.WriteLine(employees[id].ToString());
            }
            else
            {
                Console.WriteLine("Employee ID: {0} not found in Promotion List", id);
            }
        }
    }
}
