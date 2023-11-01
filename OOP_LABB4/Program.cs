namespace OOP_LABB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { ID = 101, Name = "Daniel", Gender = "Male", Salary = 25000};
            Employee emp2 = new Employee() { ID = 102, Name = "Anas", Gender = "Male", Salary = 40000};
            Employee emp3 = new Employee() { ID = 103, Name = "Johanna", Gender = "Female", Salary = 30000};
            Employee emp4 = new Employee() { ID = 104, Name = "Amanda", Gender = "Female", Salary = 50000};
            Employee emp5 = new Employee() { ID = 105, Name = "Tobias", Gender = "Male", Salary = 55000};


            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.ID} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the stack = {employees.Count}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("Retreive using pop");

            for (int i = employees.Count; i > 0; i--)
            {
                Employee popedEmp = employees.Pop();
                Console.WriteLine($"{popedEmp.ID} - {popedEmp.Name} - {popedEmp.Gender} - {popedEmp.Salary}");
                Console.WriteLine($"Items left in the stack = {employees.Count}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");

            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);

            Console.WriteLine("Retreive using peek");

            for (int i = 0; i < 2; i++)
            {
                Employee peekEmp = employees.Peek();
                Console.WriteLine($"{peekEmp.ID} - {peekEmp.Name} - {peekEmp.Gender} - {peekEmp.Salary}");
                Console.WriteLine($"Items left in the stack = {employees.Count}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");

            if (employees.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------");

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);

            if (employeeList.Contains(emp2)) 
            {
                Console.WriteLine("Emp2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Emp2 object does not exist in the list");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("First occurrence of an object which contains the value \"Male\"");

            Employee empResult = employeeList.Find(e => e.Gender == "Male");
            Console.WriteLine($"{empResult.ID} - {empResult.Name} - {empResult.Gender} - {empResult.Salary}");

            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("All objects that contains the value \"Male\"");

            List<Employee> resultList = employeeList.FindAll(e => e.Gender == "Male");

            foreach (Employee employee in resultList)
            {
                Console.WriteLine($"{employee.ID} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            }
        }
    }
}