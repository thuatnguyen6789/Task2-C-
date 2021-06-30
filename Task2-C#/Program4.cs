using System;
/// <summary>
/// The program demonstrates the use of XML comments.
/// 
/// Employee class uses constructors to initialize the ID and
/// name of the employee and displays them.
/// </summary>
/// <remarks>
/// This program uses both parameterized and
/// non-parameterized constructors.
/// </remarks>
class Employee
{
    /// <summary>
    /// Integer field to store employee ID.
    /// </summary>
    private int id;
    ///<summary>
    ///String field to store employee name.
    ///</summary>
    private string name;
    ///<summary>
    ///This constructor initializes the id and name to -1 and null.
    ///</summary>
    ///<remarks>
    ///seealsocref="Employee(int,string)">Employee(int,string)</seealso>
    ///</remarks>
    public Employee()
    {
        id = -1;
        name = null;
    }
    ///<summary>
    ///This constructor initializes the id and name.
    /// (<paramref name="id"/>,<paramref name="name"/>).
    ///</summary>
    ///<param name="id">Employee Name</param>
    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    ///<summary>
    ///The entry point for the application
    ///<param name="args">A list of command line arguments</param>
    ///</summary>

}
namespace Code7Session2
{
    class Program
    {
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creating an object of Employee class displaying the
            // id and name of the employee
            Employee objEmp = new Employee(101, "David Smith");
            Console.WriteLine("Employee ID : {0} \nEmployee Name : {1}",
            objEmp.name);
        }
    }
}
