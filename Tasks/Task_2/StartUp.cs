
namespace Task_2
{
    using static Task2.SalaryConstants;

    public static class Salary
    {
        public static decimal CalculateSalary()
        {
            Console.Write("Calculate Net salary for:");
            var input = Console.ReadLine();
          
            if (!decimal.TryParse(input, out var salary))
            {
                Console.WriteLine("Input should be number");
            }
            var netSalary = salary;
            if (salary <= Maximum_Salary_With_No_Taxation)
            {
                Console.WriteLine($"Salary net value : {netSalary:F2} IDR");
                return netSalary;
            }
            else
            {
                var tax = (netSalary - Maximum_Salary_With_No_Taxation) * Taxation_Over_Treshold;
                netSalary -= tax;
                var overTaxationSalary = salary - Maximum_Salary_With_No_Taxation;
                var taxedSalary = overTaxationSalary;

                if (salary > Maximum_Social_Contributions)
                {
                    var overTreshhold = salary - Maximum_Social_Contributions;
                    taxedSalary -= overTreshhold;

                }

                var sosialTax = taxedSalary * Social_Contributions_Tax;
                netSalary -= sosialTax;

            }
            
            Console.WriteLine($"Salary net value : {netSalary:F2} IDR");
          
            return netSalary;
        }
        public static decimal AddTaxation()
        {
            
            Console.Write("Add treshold:");

            var inpuTreshold = Console.ReadLine();
            if (!decimal.TryParse(inpuTreshold, out var treshold))
            {
                Console.WriteLine("Input should be number");
            }           
           
            Console.Write("Add percentage:");
            var inputPercentage = Console.ReadLine();
            if (!decimal.TryParse(inputPercentage, out var percentage))
            {
                Console.WriteLine("Input should be number");
            }
            Console.Write("Salary for taxation :");
            var input = Console.ReadLine();

            if (!decimal.TryParse(input, out var salary))
            {
                Console.WriteLine("Input should be number");
            }

            if (salary > treshold)
            {
                var tax = salary * percentage;
                salary -= tax;
            }
            Console.WriteLine($"Salary after tax is: {salary:F2} IDR");
            return salary;
            
        }
    }
    public class StartUp
    {

        static void Main(string[] args)
        {
            //function is used in Console, when you press ctrl+F5, you are asked to write the salary which you want to convert
            //if you need to add new taxation use addTaxation method and input data that is asked in console
            //the methods are not connected
            Salary.CalculateSalary();
            Salary.AddTaxation();
            
        }

    }
}