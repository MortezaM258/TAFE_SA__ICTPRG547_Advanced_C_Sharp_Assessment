using System;
using System.Collections.Generic;
using System.Text;

namespace Part1.Model
{
    /// <summary>
    /// Represents a general person with a name, email, and phone number.
    /// </summary>
    public class Person
    {
        // Constants for default values
        private const string DEFAULT_NAME = "No Name";
        private const string DEFAULT_EMAIL = "No Email";
        private const int DEFAULT_PHONE_NUMBER = 0;

        // Property assessor methods
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        // Relationship mapping: Person has an Address (Aggregation)
        public Address Address { get; set; }

        /// <summary>
        /// All-arguments constructor to initialize a Person object.
        /// </summary>
        public Person(string name, string email, int phoneNumber)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// No-argument constructor using constructor chaining.
        /// </summary>
        public Person() : this(DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE_NUMBER) { }

        /// <summary>
        /// Overrides the ToString method to return all object's data.
        /// </summary>
        /// <returns>A string representation of the Person.</returns>
        public override string ToString()
        {
            return "Name :" + Name + ", Email : " + Email + ", Phone Number: " + PhoneNumber;
        }
    }
}