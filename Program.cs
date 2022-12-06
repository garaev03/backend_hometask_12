namespace hometask_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new("name1", "surname1", 10);
            Employee employee2 = new("name2", "surname2", 15);
            Employee employee3 = new("name3", "surname3", 20);

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            StartWork(employees, x => x % 2 == 0);
        }

        #region method 1
        //static void StartWork(List<Employee> employees, Func<int, bool> func)
        //{
        //    List<double> salaries = new List<double>();

        //    employees.ForEach(async x => salaries.Add(await Calc.CalcEmployeeSalary(x, Calc.arr, func)));

        //    foreach (var result in employees)
        //    {
        //        Console.WriteLine( $"Employee id: {result._id} => Salary: {result.Salary}");
        //    }
        //    Console.WriteLine("\nFinished.");
        //} 
        #endregion

        #region method 2
        static async void StartWork(List<Employee> employees, Func<int, bool> func)
        {

            var salary1 = Calc.CalcEmployeeSalary(employees[0], Calc.arr, func);
            var salary2 = Calc.CalcEmployeeSalary(employees[1], Calc.arr, func);
            var salary3 = Calc.CalcEmployeeSalary(employees[2], Calc.arr, func);

            var result = await Task.WhenAll(salary1, salary2, salary3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nFinished.");
        }
        #endregion
    }
}