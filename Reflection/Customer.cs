using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    /// <summary>
    /// Customer is class in which properties, constructors and methods are declared.
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public Customer()
        {
            this.Id = -1;
            this.Name = "";
        }
        /// <summary>
        /// print customer id
        /// </summary>
        public void PrintId()
        {
            Console.WriteLine(this.Id);
        }
        /// <summary>
        /// print customer name
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
