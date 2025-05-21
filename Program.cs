using System.ComponentModel;

namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramMenu();
        }

        private static void ProgramMenu()
        {
            while (true) { 
                Console.WriteLine("Lexicon personalregister");
                Console.WriteLine("Välj mellan ett av följande alternativ:");
                Console.WriteLine("1. Skriv ut registret");
                Console.WriteLine("2. Lägg till ny anställd");
                Console.WriteLine("3. Ändra befintlig anställd");
                Console.WriteLine("4. Ta bort anställd");
                Console.WriteLine("5. Avsluta programmet");
                string usersChoice = Console.ReadLine();

                switch (usersChoice)
                {
                    case "1":
                        Console.WriteLine("\nPersonalregister: ");
                        Employee.GetListOfEmployees();
                        break;
                    case "2":
                        AddEmployeeMenu();
                        break;
                    case "3":
                            Employee.UpdateEmployee();
                        break;
                    case "4":
                            Employee.RemoveEmployee();
                        break;
                    case "5":
                        Console.WriteLine("Tack för att du använde Lexicons personalregister. Välkommen tillbaka!");
                        return;
                    default:
                        Console.WriteLine("Du har gjort en felaktig inmatning, försök igen.\n");
                        break;
                }
            }
        }

        private static void AddEmployeeMenu()
        {
            Console.WriteLine("Lägg till förnamn: ");
            string name = Console.ReadLine().ToLower();
            Console.WriteLine("Lägg till efternamn: ");
            string lastName = Console.ReadLine().ToLower();
            Console.WriteLine("Lägg till lön: ");
            string salaryInput = Console.ReadLine();

            if (int.TryParse(salaryInput, out int salary))
                Employee.AddEmployee(name, lastName, salary);
            else
                Console.WriteLine("Du har gjort en felaktig inmatning, lönen ska anges i siffror. Försök igen.\n");
        }
    }
}
