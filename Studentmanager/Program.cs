
using Studentmanager;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Student management system===");

        StudManager mgr = new StudManager();

        while (true)
        {
            Console.WriteLine("\n1) Add 2) All 3) Search by number 4) Update rating 5) Exit");
            Console.Write("Choose: ");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "1":
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("List Number: ");
                    string rollInput = Console.ReadLine();
                    if (!int.TryParse(rollInput, out int roll))
                    {
                        Console.WriteLine("The role must be a number.");
                        continue;
                    }

                    Console.Write("Assessment (A-F): ");
                    string grade = Console.ReadLine().ToUpper();

                    Student s = new Student(name, roll, grade);
                    if (mgr.AddStudent(s))
                        Console.WriteLine("Has been added.");
                    break;

                case "2":
                    mgr.ListStudents();
                    break;

                case "3":
                    Console.Write("Enter the list number: ");
                    string r = Console.ReadLine();
                    if (!int.TryParse(r, out int rollSearch))
                    {
                        Console.WriteLine("Just a number.");
                        continue;
                    }
                    var found = mgr.FindByRoll(rollSearch);
                    if (found != null)
                        Console.WriteLine(found.Info());
                    else
                        Console.WriteLine("Student not found.");
                    break;

                case "4":
                    Console.Write("List Number: ");
                    string rn = Console.ReadLine();
                    if (!int.TryParse(rn, out int rollUpdate))
                    {
                        Console.WriteLine("Just a number.");
                        continue;
                    }
                    Console.Write("New rating: ");
                    string ng = Console.ReadLine().ToUpper();

                    if (mgr.UpdateGrade(rollUpdate, ng))
                        Console.WriteLine("updated.");
                    else
                        Console.WriteLine("Student not found.");
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }
    }
}

