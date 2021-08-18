using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    /// <summary>
    /// Employer class having variables, constructor and methods are declared
    /// </summary>
    class Employer
    {
        /// <summary>
        /// variables
        /// </summary>
        readonly int id;
        readonly string name;
        /// <summary>
        /// paramerized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Employer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        [NewAttribute("Accessor", "Gives value of Employer Id")]
        public int GetId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives value of Employer Name")]
        public string GetName()
        {
            return name;
        }
    }
}
