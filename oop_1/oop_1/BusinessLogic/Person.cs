using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Person
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName {
            get {
                return _FirstName;
            }
            private set {
                _FirstName = value;
            }
        }

        public string LastName {
            get {
                return _LastName;
            }
            private set {
                _LastName = value;
            }
        }

        public Person() {
        }

        public Person(string name, string surname) {
            FirstName = name;
            LastName = surname;
        }
    }
}
