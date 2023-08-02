using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memebers_and_Finalizers
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public memeber Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}, I'm {2} years old", memberName, jobTitle, age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        public Members()
        {
            age = 30;
            memberName = "lucy";
            salary = 30000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members object.");
        }
    }
}
