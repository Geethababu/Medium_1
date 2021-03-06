﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Medium_1
{
    class Employee
    {
        int id, age;
        string name;
        double salary;

        public Employee()
        {
        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void TakeEmployeeDetailsFromUser()
        {
            try
            {
                Console.WriteLine("Please enter the employee ID");
                id = int.Parse(Console.ReadLine());
                if (EmployeePromotion.employees.ContainsKey(id))
                {
                    Console.WriteLine("Already existed, use a new ID ! ");
                    TakeEmployeeDetailsFromUser();
                    return;
                }
            }
            catch
            {
                Console.WriteLine("ID should be a number...");
                TakeEmployeeDetailsFromUser();
                return;
            }

            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();

                Console.WriteLine("Please enter the employee age");
                age = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("Please enter the employee salary");
                salary = Double.Parse(Console.ReadLine());
            

            try
            {
                EmployeePromotion.employees.Add(id, new Employee(id, age, name, salary));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ID value cannot be NULL !!!!");
                TakeEmployeeDetailsFromUser();
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This ID has been already added !!! Use a new ID. ");
                TakeEmployeeDetailsFromUser();
                return;
            }


        }

        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
        }


        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
