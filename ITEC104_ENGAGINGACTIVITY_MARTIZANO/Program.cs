public class EmployeeStruct {
    struct Employee {
        public string firstName;
        public string lastName;
        public int age;
        public string compTraining;
    }
    public static void Main(string[] args)
    {
        Employee employee1;

        employee1.firstName = "Juan";
        employee1.lastName = "Dela Cruz";
        employee1.age = 25;
        employee1.compTraining = "Yes";

        Console.WriteLine("\nYou entered");
        Console.WriteLine("First Name: " + employee1.firstName);
        Console.WriteLine("Last Name: "  + employee1.lastName);
        Console.WriteLine("Age: " + employee1.age);
        Console.WriteLine("Completed Training? " + employee1.compTraining);
        Console.ReadKey();
    }
}