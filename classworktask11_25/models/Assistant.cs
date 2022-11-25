using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworktask11_25.models
{
    internal class Assistant:Manager
    {
        Employee employee;

        public void GetFeedBack(Employee Employee)
        {
            if (Employee.IsSuccesful == true)
            {
                GetPromotion(Employee);
            }
            else
            {
                Console.WriteLine("Isci ugursuzdu");
            }
        }
    }
}
