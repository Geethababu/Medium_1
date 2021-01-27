using System;

namespace Medium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePromotion p = new EmployeePromotion();
            int check = 1;
            while (check == 1)
            {
                Employee emp = new Employee();
                emp.TakeEmployeeDetailsFromUser();        
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    check = Convert.ToInt32(Console.ReadLine());
            }
            p.FindEmployeeByID();
            Console.ReadKey();

        }
    }
}
