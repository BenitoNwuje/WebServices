using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OefeningPersonEncapsulation
{
    class Person
    {

        private DateTime birthDate;
        private string firstName;
        static private int instanceCount;
        private string lastName;
        //
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            instanceCount++;
        }

        public int Age {
            get
            {
                return DateTime.Now.Year - birthDate.Year;

            }
        }
        public string FullName {
            get
            {
                return $"{firstName} {lastName}";
            }
        
        }
         public static int InstanceCount { 
            get
            {
                return instanceCount;
            }
        } 

       
    }
}
