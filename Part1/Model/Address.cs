using System;
using System.Collections.Generic;
using System.Text;

namespace Part1.Model
{
    /// <summary>
    /// Represents a physical address.
    /// </summary>
    public class Address
    {
        // Constants for default values
        private const int DEFAULT_STREET_NUMBER = 0;
        private const string DEFAULT_STREET_NAME = "-";
        private const string DEFAULT_SUBURB = "-";
        private const int DEFAULT_POSTCODE = 0;
        private const string DEFAULT_STATE = "-";

        // Property assessor methods
        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public int Postcode { get; set; }
        public string State { get; set; }

        /// <summary>
        /// All-arguments constructor to initialize an Address object.
        /// </summary>
        public Address(int streetNum, string streetName, string suburb, int postcode, string state)
        {
            this.StreetNum = streetNum;
            this.StreetName = streetName;
            this.Suburb = suburb;
            this.Postcode = postcode;
            this.State = state;
        }

        /// <summary>
        /// No-argument constructor using constructor chaining.
        /// </summary>
        public Address() : this(DEFAULT_STREET_NUMBER, DEFAULT_STREET_NAME, DEFAULT_SUBURB, DEFAULT_POSTCODE, DEFAULT_STATE) { }

        /// <summary>
        /// Overrides the ToString method to return all object's data.
        /// </summary>
        /// <returns>A string representation of the Address.</returns>
        public override string ToString()
        {
            return "Address :" + StreetNum + ", " + StreetName + ", " + Suburb + ", " + State + ", " + Postcode;
        }
    }
}