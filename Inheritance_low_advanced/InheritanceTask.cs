using System;

namespace InheritanceTask
{
    class InheritanceTask
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Tony", 2000);
            employee.SetBonus(300);
            SalesPerson salesPerson = new SalesPerson("Gary", 3000, 101);
            salesPerson.SetBonus(200);
        }
    }
    class Employee
    {
        private string name;
        private decimal salary;
        private decimal bonus;
        public string Last_name { get; }
        public decimal Salary { get; set; }
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }
        public decimal ToPay()
        {
           decimal sum = 0;
           return sum = bonus + salary;
        }
    }

    class SalesPerson : Employee
    {
        private int percent;
        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
          this.percent = percent;
        }
        public override void SetBonus(decimal bonus) 
        {
            if (percent > 100)
            {
                bonus *= 2;
            }
           else if(percent > 200)
            {
                bonus *= 3;
            }
        }

    }

    class Manager : Employee
    {
        private int quantity;

        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            quantity = clientAmount;
        }
        public override void SetBonus(decimal bonus)
        {
            if (quantity > 100)
            {
                bonus += 500;
            }
            else if (quantity > 150)
            {
                bonus += 1000;
            }
        }
    }
    class Company
    {
        private Employee[] employees;
        public Company(Employee[] employees)
        {
            this.employees = employees;
        }
        public void GiveEverbodyBonus(decimal companyBonus)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].SetBonus(companyBonus);
            }
        }
        public void TotalToPay()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].ToPay();
            }
        }
        public string NameMaxSalary()
        {
            decimal salary = 0;
            decimal maxSalary = 0;
            int index = 0;
            for (int i = 0; i < employees.Length; i++)
            {
               salary = employees[i].ToPay();
                if (salary > maxSalary)
                {
                    maxSalary = salary;
                    index = i;
                }
            }
            return employees[index].Last_name;
        }

    }
}
