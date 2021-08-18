using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflection
{
    class NewAttribute : Attribute
    {
        // private fields
        private string title;
        private string description;
        //paramerized constructor
        public NewAttribute(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
        /// <summary>
        /// display attribute using reflection
        /// </summary>
        /// <param name="classtype"></param>
        public static void AttributeDisplay(Type classtype)
        {
            Console.WriteLine("Mothods of class {0}", classtype);
            //// Array to store all the methods
            MethodInfo[] methods = classtype.GetMethods();
            for (int i=0; i< methods.GetLength(0); i++)
            {
                //// creating object to method attribute returned by the GetCustomAttributes methods
                object[] attributesArray = methods[i].GetCustomAttributes(true);
                //// traversing the data present in atrributesArray
                foreach (Attribute data in attributesArray)
                {
                    if (data is NewAttribute)
                    {
                        //// display the fields of NewAttribute
                        NewAttribute newAttributeObject = (NewAttribute)data;
                        Console.WriteLine("{0} - {1}, {2}", methods[i].Name, newAttributeObject.title, newAttributeObject.description);
                    }
                }
            }
        }
    }
}
