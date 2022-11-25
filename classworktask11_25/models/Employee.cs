using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworktask11_25.models
{
    internal class Employee
    {
        string _name;
        bool issuccesful;
        int _salary;

        internal string Name
        {
            get { return _name; }
            set
            {
                value = value.Trim();
                if (value.Length > 2 && value.Length < 15)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong name!!!!");
                }
            }
        }
        internal int Salary
        {
            get { return _salary; }
            set
            {
                if (value> 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Wrong Salary!!!!");
                }
            }
        }
        internal bool IsSuccesful
        { 
            get { return issuccesful; }     
            set { issuccesful = value; }
        }

        public Employee(string Name, int Salary , bool isSuccesful)
        {
            Name = Name;
            Salary = Salary;    
            isSuccesful = isSuccesful;
        }
    }
}
