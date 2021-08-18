using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    /// <summary>
    /// Employee class having variables, constructor and methods are declared
    /// </summary>
    class Employee
    {
        /// <summary>
        /// variables declaration
        /// </summary>
        readonly int id;
        readonly string name;
        /// <summary>
        /// paramerized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        [NewAttribute("Accessor", "Gives value of Employee Id")]
        public int GetId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives value of Employee Name")]
        public string GetName()
        {
            return name;
        }
    }
}
