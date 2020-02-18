using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class CreatingEmployesList
    {
        static int NumberOfCompanies = 0;
        //Creating String object
        static string[] CompanyNames = new string[NumberOfCompanies];
        public static void CreatingCSVFile(List<EmployeeDetails> employeeDetails)
        {
            string path = @"G:\task3\";
            try
            {
                //creating streamWriter object 
                using (StreamWriter file = new StreamWriter(@path + "Company1_Data.csv", true))
                {
                    //writing colomn names in the file
                    file.WriteLine("S.No, " + "Employee_ID, " + "Employee_Name, " + "Company_ID, " + "Company_Name, " + "Designation, " + "Department ");
                    // writing emloyees details into the file
                    foreach (EmployeeDetails emp in employeeDetails)
                    {
                        if (emp.company_name[0].Equals("Dell"))
                        {
                            file.WriteLine(emp.S_NO + "," + emp.employee_id + "," + emp.employee_name + "," + emp.company_id + "," + emp.company_name + "," + emp.designation + "," + emp.department);
                        }
                    }
                }
                //creating streamWriter object 
                using (StreamWriter file = new StreamWriter(@path + "Company2_Data.csv", true))
                {
                    //writing colomn names in the file
                    file.WriteLine("S.No, " + "Employee_ID, " + "Employee_Name, " + "Company_ID, " + "Company_Name, " + "Designation, " + "Department ");
                    // writing emloyees details into the file
                    foreach (EmployeeDetails emp in employeeDetails)
                    {
                        if (emp.company_name[1].Equals("Oracle"))
                        {
                            file.WriteLine(emp.S_NO + "," + emp.employee_id + "," + emp.employee_name + "," + emp.company_id + "," + emp.company_name + "," + emp.designation + "," + emp.department);
                        }
                    }
                }
                //creating streamWriter object 
                using (StreamWriter file = new StreamWriter(@path + "Company3_Data.csv", true))
                {
                    //writing colomn names in the file
                    file.WriteLine("S.No, " + "Employee_ID, " + "Employee_Name, " + "Company_ID, " + "Company_Name, " + "Designation, " + "Department ");
                    // writing emloyees details into the file
                    foreach (EmployeeDetails emp in employeeDetails)
                    {
                        if (emp.company_name[2].Equals("MicroSoft"))
                        {
                            file.WriteLine(emp.S_NO + "," + emp.employee_id + "," + emp.employee_name + "," + emp.company_id + "," + emp.company_name + "," + emp.designation + "," + emp.department);
                        }
                    }
                }
                //creating streamWriter object 
                using (StreamWriter file = new StreamWriter(@path + "Company4_Data.csv", true))
                {
                    //writing colomn names in the file
                    file.WriteLine("S.No, " + "Employee_ID, " + "Employee_Name, " + "Company_ID, " + "Company_Name, " + "Designation, " + "Department ");
                    // writing emloyees details into the file
                    foreach (EmployeeDetails emp in employeeDetails)
                    {
                        if (emp.company_name[3].Equals("Infosys"))
                        {
                            file.WriteLine(emp.S_NO + "," + emp.employee_id + "," + emp.employee_name + "," + emp.company_id + "," + emp.company_name + "," + emp.designation + "," + emp.department);
                        }
                    }
                }
                //creating streamWriter object 
                using (StreamWriter file = new StreamWriter(@path + "Company5_Data.csv", true))
                {
                    //writing colomn names in the file
                    file.WriteLine("S.No, " + "Employee_ID, " + "Employee_Name, " + "Company_ID, " + "Company_Name, " + "Designation, " + "Department ");
                    // writing emloyees details into the file
                    foreach (EmployeeDetails emp in employeeDetails)
                    {
                        if (emp.company_name[4].Equals("Wipro"))
                        {
                            file.WriteLine(emp.S_NO + "," + emp.employee_id + "," + emp.employee_name + "," + emp.company_id + "," + emp.company_name + "," + emp.designation + "," + emp.department);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Handling if any exception raised while writing into file
                Console.WriteLine("Unhandled Exception: " + ex.ToString());
            }
        }

        public static List<EmployeeDetails> createEmployees()
        {
            List<EmployeeDetails> employee = new List<EmployeeDetails>();
            //asking user to enter number of companies to store
            Console.WriteLine("Enter Number Of Companies To Store");
            //Converting string to integer
            CreatingEmployesList.NumberOfCompanies = int.Parse(Console.ReadLine());
            //Reading company names
            for (int i = 0; i < NumberOfCompanies; i++)
            {
                Console.WriteLine($"Enter {i} Company Name");
                CompanyNames[i] = Console.ReadLine();
            }
            //Asking for number of employees per company
            Console.WriteLine("Enter number of Employees per company");
            //converting string to integer
            int EmployeesPerCompany = int.Parse(Console.ReadLine());
            // Intilizing companyid array
            int[] CompanyIds = new int[NumberOfCompanies];
            for (int i = 0; i < NumberOfCompanies; i++)
            {
                //reading company is for particular company
                Console.WriteLine($"Enter company id for {CompanyNames[i]}");
                //converting string to int
                CompanyIds[i] = int.Parse(Console.ReadLine());
            }
            for (int CompaniesCount = 0; CompaniesCount < NumberOfCompanies; CompaniesCount++)
            {
                int nameCount = 1;
                int id = 1001;
                int s_no = 1;
                for (int i = 0; i < EmployeesPerCompany; i++)
                {
                    EmployeeDetails employeeDetails1 = new EmployeeDetails
                    {
                        S_NO = s_no,
                        employee_id = id,
                        employee_name = CompanyNames[CompaniesCount] + nameCount,
                        company_id = CompanyIds[CompaniesCount],
                        company_name = CompanyNames[CompaniesCount],
                        designation = Designation.Infra,
                        department = Department.QA
                    };
                    nameCount++;
                    id++;
                    s_no++;
                    employee.Add(employeeDetails1);
                    EmployeeDetails employeeDetails2 = new EmployeeDetails
                    {
                        S_NO = s_no,
                        employee_id = id,
                        employee_name = CompanyNames[CompaniesCount] + nameCount,
                        company_id = CompanyIds[CompaniesCount],
                        company_name = CompanyNames[CompaniesCount],
                        designation = Designation.juniorHR,
                        department = Department.HR
                    };
                    nameCount++;
                    id++;
                    s_no++;
                    employee.Add(employeeDetails2);
                    EmployeeDetails employeeDetails3 = new EmployeeDetails
                    {
                        S_NO = s_no,
                        employee_id = id,
                        employee_name = CompanyNames[CompaniesCount] + nameCount,
                        company_id = CompanyIds[CompaniesCount],
                        company_name = CompanyNames[CompaniesCount],
                        designation = Designation.seniorHR,
                        department = Department.HR
                    };
                    nameCount++;
                    id++;
                    s_no++;
                    employee.Add(employeeDetails3);
                    EmployeeDetails employeeDetails4 = new EmployeeDetails
                    {
                        S_NO = s_no,
                        employee_id = id,
                        employee_name = CompanyNames[CompaniesCount] + nameCount,
                        company_id = CompanyIds[CompaniesCount],
                        company_name = CompanyNames[CompaniesCount],
                        designation = Designation.SoftwareDeveloper,
                        department = Department.Dev
                    };
                    nameCount++;
                    id++;
                    s_no++;
                    employee.Add(employeeDetails4);
                    EmployeeDetails employeeDetails5 = new EmployeeDetails
                    {
                        S_NO = s_no,
                        employee_id = id,
                        employee_name = CompanyNames[CompaniesCount] + nameCount,
                        company_id = CompanyIds[CompaniesCount],
                        company_name = CompanyNames[CompaniesCount],
                        designation = Designation.Manager,
                        department = Department.Management
                    };
                    nameCount++;
                    id++;
                    s_no++;
                    employee.Add(employeeDetails5);
                }
            }
            return employee;
        }
    }
}
