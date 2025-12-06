namespace DesignPattern.Adapter
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray)
        {
            BillingSystem billingSystem = new BillingSystem();
            List<Employee> outEmployees = new List<Employee>();

            for (int i = 0; i < employeesArray.Length-1; i++)
            {
                Employee newEmployee = new Employee(
                    int.Parse(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i, 2],
                    decimal.Parse(employeesArray[i, 3])
                );

                outEmployees.Add(newEmployee);
            }

            billingSystem.ProcessSalary(outEmployees);
        }
    }
}
