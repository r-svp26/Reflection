using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        /// <summary>
        /// display list of methods, propertys, constructors and class details by reflection
        /// </summary>
        public static void Invoke()
        {
            //// get the type of class using Type class static methed GetType.
            Type type = Type.GetType("Reflection.Customer");
            //// printing full name of the class.
            Console.WriteLine("Full Name is {0}", type.FullName);
            //// printing class name.
            Console.WriteLine("Class Name is {0}", type.Name);

            Console.WriteLine("Methods in Customer class");
            //// MethodInfo is a class where methods of Customer class is stored in the form of array.
            MethodInfo[] methods = type.GetMethods();
            //// traversing the present in the method object.
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine("Properties in Customer class");
            //// PropertyInfo is a class where properties of Customer class is stored in the form of array.
            PropertyInfo[] properties = type.GetProperties();
            //// traversing the data present in the property object.
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in Customer class");
            //// ConstructorInfo is a class where constructors of Customer class is stored in the form of array.
            ConstructorInfo[] constructors= type.GetConstructors();
            //// traversing the data present in the constructor object.
            foreach ( ConstructorInfo constructor in constructors)
            {
                Console.WriteLine( constructor.ToString());
            }
        }
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Invoke();
        }
    }
}
