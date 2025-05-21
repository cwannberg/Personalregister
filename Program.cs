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
            Console.WriteLine("Lexicon personalregister");
            Console.WriteLine("Välj mellan ett av följande alternativ:");
            Console.WriteLine("1. Skriv ut registret");
            Console.WriteLine("2. Lägg till ny anställd");
            Console.WriteLine("3. Ändra befintlig anställd");
            Console.WriteLine("4. Ta bort anställd");
            string usersChoice = Console.ReadLine();

            switch (usersChoice)
            {
                case "1":
                    Console.WriteLine("\nPersonalregister: ");
                    Employee.GetListOfEmployees();
                    break;
                case "2":
                    Console.WriteLine("Lägg till förnamn: ");
                    string name = Console.ReadLine().ToLower();
                    Console.WriteLine("Lägg till efternamn: ");
                    string lastName = Console.ReadLine().ToLower();
                    Console.WriteLine("Lägg till lön: ");
                    string salaryInput = Console.ReadLine();

                    if(int.TryParse(salaryInput, out int salary))
                        Employee.AddEmployee(name, lastName, salary);
                    else
                        Console.WriteLine("Du har gjort en felaktig inmatning, lönen ska anges i siffror. Försök igen.\n");
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Du har gjort en felaktig inmatning, försök igen.\n");
                    break;
            }
            ProgramMenu();
        }
    }
}
