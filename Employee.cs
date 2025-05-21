namespace Personalregister
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        private static int idCounter = 1;

        public static List<Employee> ListOfEmployees = new List<Employee>();

        public Employee(string name, string lastName, int salary)
        {
            Id = idCounter++;
            Name = char.ToUpper(name[0]) + name.Substring(1);
            LastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
            Salary = salary;
        }

        public static void GetListOfEmployees()
        {
            if (ListOfEmployees.Count > 0)
            {
                foreach (var employee in ListOfEmployees)
                {
                    Console.WriteLine($"Id: {employee.Id} Namn: {employee.Name} {employee.LastName} Lön: {employee.Salary}");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Listan är tyvärr tom\n");
            }
        }
        public static void AddEmployee(string name, string lastName, int salary)
        {
            ListOfEmployees.Add(new Employee(name, lastName, salary));
        }
        public static void UpdateEmployee()
        {
            if(ListOfEmployees.Count <= 0)
            {
                Console.WriteLine("Listan är tom");
                return;
            }
            Console.WriteLine("Ange id på personen du vill ändra");
            if (int.TryParse(Console.ReadLine(), out int idToUpdate))
            {
                var employeeToUpdate = ListOfEmployees.FirstOrDefault(e => e.Id == idToUpdate);
                if (employeeToUpdate != null)
                {
                    Console.WriteLine($"Uppdaterar {employeeToUpdate.Name} {employeeToUpdate.LastName}");

                    Console.Write("Nytt förnamn: ");
                    string newName = Console.ReadLine();
                    Console.Write("Nytt efternamn: ");
                    string newLastName = Console.ReadLine();
                    Console.Write("Ny lön: ");
                    string salaryInput = Console.ReadLine();

                    if (int.TryParse(salaryInput, out int newSalary))
                    {
                        employeeToUpdate.Name = char.ToUpper(newName[0]) + newName.Substring(1);
                        employeeToUpdate.LastName = char.ToUpper(newLastName[0]) + newLastName.Substring(1);
                        employeeToUpdate.Salary = newSalary;

                        Console.WriteLine("Anställd uppdaterad!");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig lön – uppdatering avbruten.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingen anställd med det id:t hittades.");
                }
            }
        }
        public static void RemoveEmployee()
        {
            if (ListOfEmployees.Count <= 0)
            {
                Console.WriteLine("Listan är tom");
                return;
            }
            Console.WriteLine("Ange id på personen du vill radera");
            if (int.TryParse(Console.ReadLine(), out int idToRemove))
            {
                var employeeToRemove = ListOfEmployees.FirstOrDefault(e => e.Id == idToRemove);
                if (employeeToRemove != null)
                {
                    ListOfEmployees.Remove(employeeToRemove);
                    Console.WriteLine("Den anställda är borttagen från listan");
                }
                else
                {
                    Console.WriteLine("Ingen anställd med det id:t hittades.");
                }
            }
        }
    }
}
