namespace MVC_Grid.Models
{
    public class Employee
    {
        public int ID { get; set; }        // Column 1

        public string Name { get; set; }    // Column 2

        public string Gender { get; set; }  // Column 3

        public string Address { get; set; } // Column 4

        // New columns
        public string Department { get; set; }  // Column 5

        public decimal Salary { get; set; }     // Column 6
    }

}