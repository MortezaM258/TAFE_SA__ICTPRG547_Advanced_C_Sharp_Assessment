using System;

namespace Part1.Model
{
    /// <summary>
    /// Represents a subject with a code, name, and cost.
    /// </summary>
    public class Subject
    {
        // Constants for default values
        private const int DEFAULT_SUBJECT_CODE = 0;
        private const string DEFAULT_SUBJECT_NAME = "No Name";
        private const double DEFAULT_COST = 0.0;

        // Property assessor methods
        public int SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// All-arguments constructor to initialize a Subject object.
        /// </summary>
        public Subject(int subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        /// <summary>
        /// No-argument constructor using constructor chaining.
        /// </summary>
        public Subject() : this(DEFAULT_SUBJECT_CODE, DEFAULT_SUBJECT_NAME, DEFAULT_COST) { }

        /// <summary>
        /// Overrides the ToString method to return all object's data.
        /// </summary>
        /// <returns>A string representation of the Subject.</returns>
        public override string ToString()
        {
            return "Subject Code is: " + SubjectCode + ", Subject Name: " + SubjectName + ", Cost :" + Cost;
        }
    }
}