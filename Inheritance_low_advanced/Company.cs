using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
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
