using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
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
}
