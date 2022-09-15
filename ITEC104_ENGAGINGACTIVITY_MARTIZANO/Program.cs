public class EmployeeStruct {
    struct Employee {
        public string firstName;
        public string lastName;
        public int age;
        public string compTraining;
    }
    public static void Main(string[] args){

        Employee emp1;

        Console.WriteLine("Enter your First Name: ");
        emp1.firstName = Console.ReadLine();
        Console.WriteLine("Enter your Last Name: ");
        emp1.lastName = Console.ReadLine();
        Console.WriteLine("Enter your Age: ");
        emp1.age = int.Parse(Console.ReadLine());
        Console.WriteLine("Completed Training?");
        emp1.compTraining = Console.ReadLine();
        Console.WriteLine("\nYou entered");
        Console.WriteLine("First Name: " + emp1.firstName);
        Console.WriteLine("Last Name: "  + emp1.lastName);
        Console.WriteLine("Age: " + emp1.age);
        Console.WriteLine("Completed Training? " + emp1.compTraining);
    }
}