using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string name;

        public string Name
        {
            get { return this.name; }

            set
            {
                this.name = value;
            }
        }

        #region Salary 欄位與屬性

        private int salary;

        /// <summary>
        /// Salary 薪資屬性 範圍是22000 ~ 50000
        /// </summary>
        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value > 50000)
                    this.salary = 50000;
                else if (value < 22000)
                    this.salary = 22000;
                else
                    this.salary = value;
            }
        }

        public int GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(int value)
        {
            if (value > 50000)
                this.salary = 50000;
            else if (value < 22000)
                this.salary = 22000;
            else
                this.salary = value;
        }

        #endregion Salary 欄位與屬性
    }
}