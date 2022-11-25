using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworktask11_25.models
{
    internal class Manager
    {
        Employee employee;

        protected private Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            return employee;
        }
    }
}
