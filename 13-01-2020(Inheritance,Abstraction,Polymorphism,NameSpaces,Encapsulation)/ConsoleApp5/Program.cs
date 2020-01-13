using System;

namespace ConsoleApp5
{
    class Employee
    {
        public int id;
        public String name;
        public Address address;//HAS-A relation
        public Employee(int id, String name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + address.addressLine + " " + address.city + " " + address.state + " " + address.country);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("13 - 89 / 1", "Bangarore", "Karnataka", "INDIA");
            Address a2 = new Address("1-6/1", "Bangalore", "Karnataka", "INDIA");
            Employee emp = new Employee(1, "raju", a1);
            Employee emp1 = new Employee(2, "rani", a2);
            emp.display();
            emp1.display();
        }
    }
}
