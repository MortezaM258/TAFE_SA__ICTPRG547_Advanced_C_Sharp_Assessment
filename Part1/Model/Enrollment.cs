using System;

namespace Part1.Model
{
    /// <summary>
    /// Represents an enrollment record containing the date, grade, semester, and related subject.
    /// </summary>
    public class Enrollment
    {
        // Constants for default values
        private const string DEFAULT_GRADE = "N/A";
        private const string DEFAULT_SEMESTER = "Unknown";

        // Property assessor methods (PascalCase)
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }

        // Relationship mapping: Enrollment has a Subject (Aggregation)
        public Subject Subject { get; set; }

        /// <summary>
        /// All-arguments constructor to initialize an Enrollment object.
        /// </summary>
        public Enrollment(DateTime dateEnrolled, string grade, string semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        /// <summary>
        /// No-argument constructor using constructor chaining.
        /// </summary>
        public Enrollment() : this(DateTime.Now, DEFAULT_GRADE, DEFAULT_SEMESTER, new Subject())
        {
        }

        /// <summary>
        /// Overrides the ToString method to return all object's data.
        /// </summary>
        /// <returns>A string representation of the Enrollment.</returns>
        public override string ToString()
        {
            return $"Date Enrolled: {DateEnrolled.ToShortDateString()}, Grade: {Grade}, Semester: {Semester}, Subject Info: [{Subject?.ToString()}]";
        }
    }
}