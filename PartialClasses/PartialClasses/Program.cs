using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Naruto = new Person("Naruto", "Uzumaki", 16);
            SoccerPlayer Messi = new SoccerPlayer("Lionel", "Messi", 31);

            // Currently using SoccerPlayer constructor. Remove the parameters from the 
            // SoccerPlayer constructor (SoccerPlayer()), to see how the base class 
            // constructor is being used by the derived class. 
            SoccerPlayer NoName = new SoccerPlayer();
           
            Console.WriteLine($"Name: {Naruto.Name}, Last Name: {Naruto.LastName}, " +
                              $"{Naruto.Age}");

            Console.WriteLine($"PLayer Name: {Messi.Name}, Player Lastname: {Messi.LastName}," +
                              $"Player Age: {Messi.Age}");
            
            Console.WriteLine($"PLayer Name: {NoName.Name}, Player Lastname: {NoName.LastName}," +
                              $"Player Age: {NoName.Age}");
        }
    }

    /// <summary>
    /// Use of partial class. 
    /// Person class is dividen into multiple partial classes. 
    /// Partial class #1
    /// </summary>
    public partial class Person {
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

    /// <summary>
    /// Person Partial class #2
    /// </summary>
    public partial class Person {
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

    /// <summary>
    /// SoccerPlayer inherites from Person. This Example shows how constructors 
    /// can be used between base class and derived class. 
    /// </summary>
    public class SoccerPlayer : Person {
        public SoccerPlayer() {
            this.Name = "No Player Name";
            this.LastName = "No Player Last Name";
            this.Age = 0;
        }

        // public SoccerPlayer() {} -> Will use Person() constructor

        public SoccerPlayer(string name, string lastName, int age) : base(name, lastName, age){
            // Use BaseClass Constructor
        }
    }
}
