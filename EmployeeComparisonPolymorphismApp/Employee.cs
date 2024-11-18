using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComparisonPolymorphismApp
{
    public class Employee : IQuittable
    {
        // Properties to store employee information.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator as well, as it must be paired with "==".
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }

        // Implement the Quit() method from the IQuittable interface.
        public void Quit()
        {
            // Output a message indicating the employee has quit.
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }

}
