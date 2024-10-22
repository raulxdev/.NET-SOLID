namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }


        public  Employee(string fullname, int hoursWorked, int extrahours)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        protected Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }


        public abstract decimal CalculateSalary();

       
    }
}