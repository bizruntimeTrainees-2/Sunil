using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<EmployeeDetails> employesList = CreatingEmployesList.createEmployees();
            CreatingEmployesList.CreatingCSVFile(employesList);
        }
    }
}
