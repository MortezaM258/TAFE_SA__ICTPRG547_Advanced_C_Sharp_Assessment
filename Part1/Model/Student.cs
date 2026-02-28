using System;

namespace Part1.Model
{
    /// <summary>
    /// Represents a student. Inherits from the Person class.
    /// </summary>
    public class Student : Person
    {
        // Constants for default values
        private const int DEFAULT_STUDENT_ID = 0;
        private const string DEFAULT_PROGRAM = "Undeclared";

        // Property assessor methods
        public int StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }



        // Relationship mapping: Student has an Enrollment
        public Enrollment Enrollment { get; set; }




        /// <summary>
        /// All-arguments constructor to initialize a Student object. 
        /// Uses :base() to pass parameters to the parent Person class.
        /// </summary>
        public Student(int studentId, string program, DateTime dateRegistered, Enrollment enrollment, string name, string email, int phoneNumber)
            : base(name, email, phoneNumber)
        {
            StudentID = studentId;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }

        /// <summary>
        /// Constructor that only includes the studentID, as explicitly required in the project specifications.
        /// </summary>
        public Student(int studentId) : this(studentId, DEFAULT_PROGRAM, DateTime.Now, new Enrollment(), "No Name", "No Email", 0)
        {
        }

        /// <summary>
        /// No-argument constructor using constructor chaining.
        /// </summary>
        public Student() : this(DEFAULT_STUDENT_ID)
        {
        }

        /// <summary>
        /// Overrides the ToString method to return all object's data, including data from the base Person class.
        /// </summary>
        /// <returns>A string representation of the Student.</returns>
        public override string ToString()
        {
            return base.ToString() + $", Student ID: {StudentID}, Program: {Program}, Date Registered: {DateRegistered.ToShortDateString()}, Enrollment Info: [{Enrollment?.ToString()}]";
        }




        // PART 1: HASHING :)   :)   :)   :)   :)   :)   :)   :)   :)   :)   :)   :)   :)


        /// <summary>
        /// Logically compares two students based on their unique StudentID.
        /// </summary>
        public override bool Equals(object obj)
        {
            // Check if the object is null or if the types do not match
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Cast the object to a Student and compare StudentIDs
            Student otherStudent = (Student)obj;
            return StudentID == otherStudent.StudentID;
        }

        /// <summary>
        /// Returns a hash code based on the StudentID for optimized searching.
        /// </summary>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        /// <summary>
        /// Overloads the == operator to use the Equals logic.
        /// </summary>
        public static bool operator ==(Student s1, Student s2)
        {
            if (ReferenceEquals(s1, null))
            {
                return ReferenceEquals(s2, null);
            }
            return s1.Equals(s2);
        }

        /// <summary>
        /// Overloads the != operator.
        /// </summary>
        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1 == s2);
        }
    }
}