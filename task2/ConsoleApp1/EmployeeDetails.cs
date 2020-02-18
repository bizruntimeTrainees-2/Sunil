using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EmployeeDetails
    {
        public int S_NO { set; get; }
        public int employee_id { set; get; }
        public string employee_name { set; get; }
        public string company_name { set; get; }
        public int company_id { set; get; }
        public Designation designation { set; get; }
        public Department department { set; get; }

    }
    public enum Designation
    {
        juniorHR,
        seniorHR,
        SoftwareDeveloper,
        Infra,
        Manager
    }
    public enum Department
    {
        HR,
        Dev,
        Testing,
        QA,
        Management,

    }
}
