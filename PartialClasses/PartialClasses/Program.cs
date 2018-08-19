using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Naruto = new Person("Naruto", "Uzumaki", 16);
            Console.WriteLine($"Name: {Naruto.Name}, Last Name: {Naruto.LastName}, " +
                              $"{Naruto.Age}");
        }
    }

    partial class Person {
        private string name;
        private string lastName;
        public Person() {
            this.name = "No Name";
            this.lastName = "No Last Name";
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age {
            get { return this.age; }
            set { this.age = value; }
        }
    }

    partial class Person {
        private int age;
        public Person(string name, string lastName, int age) {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public string LastName {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
    }
}
