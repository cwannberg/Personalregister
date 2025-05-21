using System.Xml;

namespace Personalregister
{
    public class Employee(string name, string lastName, int salary)
    {
        public string Name { get; } = name;
        public string LastName { get; } = lastName;
        public int Salary { get; } = salary;

        public static List<Employee> ListOfEmployees = new List<Employee>();

        public static void GetListOfEmployees()
        {
            if (ListOfEmployees.Count > 0)
            {
                foreach (var employee in ListOfEmployees)
                {
                    Console.WriteLine($"Namn: {employee.Name} {employee.LastName} Lön: {employee.Salary}");
                }
            }
            else
            {
                Console.WriteLine("Listan är tyvärr tom\n");
            }
        }
        public static void AddEmployee(string name, string lastName, int salary)
        {
            name = char.ToUpper(name[0]) + name.Substring(1);
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);

            ListOfEmployees.Add(new Employee(name, lastName, salary));
        }
        private void UpdateEmployee()
        {

        }
        private void RemoveEmployee()
        {

        }
    }
}
