using EmployeeDetails;

class Manager :Employee { //Inhetied from Employee
    // public string EmployeeName { get; set; }
    public double salary { get; set; }
    public int EmployeeAllowances { get; set; }

    
   public Manager(int EmployeeId, string EmployeeName, string EmployeeCity, double salary, int EmployeeAllowances ) : base( EmployeeId, EmployeeName, EmployeeCity){
//    public Manager(int EmployeeId, string EmployeeName, string EmployeeCity): base(EmployeeId, EmployeeName, EmployeeCity){
    // in trhe base keyword the files of inherited parameters are written 
    // this.EmployeeId = EmployeeId;
    // this.EmployeeName = EmployeeName;
    // this.EmployeeCity = EmployeeCity;
    this.salary = salary;
    this.EmployeeAllowances = EmployeeAllowances;

   }

    public void ManagerDetails(){
        Console.WriteLine($"person With :{EmployeeId}");
        Console.WriteLine($"person with :  {EmployeeName}");
        Console.WriteLine($"person With :  {EmployeeCity}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Allowances: {EmployeeAllowances}");
     }

    }
