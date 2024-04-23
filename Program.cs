

using EmployeeDetails;

// namespace CopyDetails{

    public class Program{
        public static void Main(string[] args){
            // Employee s = new Employee(12, "Ajay", "Hyderabad");
            Manager b = new Manager(1243324, "Prasan", "Bangloore", 5394.84,  57784);
            // Manager b = new Manager(1243324, "Prasan", "Bangloore");

            // s.EmployeeDetails();
            b.ManagerDetails();
            Console.WriteLine("ajay");
        }
    }
// }