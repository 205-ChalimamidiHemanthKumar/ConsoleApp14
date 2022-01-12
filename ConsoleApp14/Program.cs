using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EmployeeContext())
            {
                List<EmployeeDetails> employeeDetails = context.EmployeeDetails.ToList();
                foreach (var employeeDetail in employeeDetails )
                {
                    Console.WriteLine(employeeDetail.Address);
                }
            }
        }
    }
}
