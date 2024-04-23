namespace EmployeeDetails{
    public class Employee { // class
        public int EmployeeId{get;set;} //fields and properties
        public string EmployeeName{get; set;}

        public string EmployeeCity{get; set;}

        public Employee(int EmployeeId, string EmployeeName,string EmployeeCity ){ //constructor calling with filelds name
            this.EmployeeId = EmployeeId; // instance values with this keyword
            this.EmployeeName = EmployeeName;
            this.EmployeeCity = EmployeeCity;
        }

        public void EmployeeDetails(){ // method is calling
            // Console.WriteLine($"Id of {EmployeeId}");
            // Console.WriteLine($"Name of {EmployeeName}");
            // Console.WriteLine($"Location of {EmployeeCity}");
        }
    }
}