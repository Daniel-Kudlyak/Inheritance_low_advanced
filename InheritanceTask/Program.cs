using System;

namespace InheritanceTask
{
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
}
