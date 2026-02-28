using System;
using Part1.Model;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing No-Argument Constructors ===");

            Address defaultAddress = new Address();
            Person defaultPerson = new Person();
            Subject defaultSubject = new Subject();
            Enrollment defaultEnrollment = new Enrollment();
            Student defaultStudent = new Student();

            Console.WriteLine(defaultAddress.ToString());
            Console.WriteLine(defaultPerson.ToString());
            Console.WriteLine(defaultSubject.ToString());
            Console.WriteLine(defaultEnrollment.ToString());
            Console.WriteLine(defaultStudent.ToString());


            Console.WriteLine("\n=== Testing All-Arguments Constructors ===");

            // Creating test objects with full information
            Address myAddress = new Address(120, "Currie St", "Adelaide", 5000, "SA");
            Person myPerson = new Person("Morteza", "morteza@email.com", 412345678);
            Subject mySubject = new Subject(547, "Advanced Programming", 1200.00);

            // Assigning subject to enrollment
            Enrollment myEnrollment = new Enrollment(DateTime.Now, "High Distinction", "Semester 1", mySubject);

            // Creating a student with all information and passing the enrollment object
            Student myStudent = new Student(9876543, "Diploma of IT", DateTime.Now, myEnrollment, "Morteza", "morteza@email.com", 412345678);

            Console.WriteLine(myAddress.ToString());
            Console.WriteLine(myPerson.ToString());
            Console.WriteLine(mySubject.ToString());
            Console.WriteLine(myEnrollment.ToString());
            Console.WriteLine(myStudent.ToString());


            Console.WriteLine("\n=== Testing Student ID-Only Constructor ===");

            // Testing the constructor specific to the Student class that only takes a student ID
            Student idOnlyStudent = new Student(11223344);
            Console.WriteLine(idOnlyStudent.ToString());


            //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


            // TESTING HASHING METHODS (Equals, GetHashCode, ==, !=)

            Console.WriteLine("\n=== Testing Hashing Methods ===");

            // Create two student objects with different data but the SAME StudentID
            Student studentA = new Student(55555, "Diploma of IT", DateTime.Now, new Enrollment(), "Morteza", "morteza@email.com", 123456);
            Student studentB = new Student(55555, "Cyber Security", DateTime.Now, new Enrollment(), "John", "john@email.com", 654321);

            // Create a third student with a DIFF StudentID
            Student studentC = new Student(99999, "Networking", DateTime.Now, new Enrollment(), "Sarah", "sarah@email.com", 111111);

            // Test '==' operator (Should return True because IDs are 55555)
            Console.WriteLine($"studentA == studentB: {studentA == studentB}");

            // Test 'Equals' method (Should return True)
            Console.WriteLine($"studentA.Equals(studentB): {studentA.Equals(studentB)}");

            // Test '==' operator (Should return False because 55555 is not equal to 99999)
            Console.WriteLine($"studentA == studentC: {studentA == studentC}");

            // Test '!=' operator (Should return True because 55555 is not equal to 99999)
            Console.WriteLine($"studentA != studentC: {studentA != studentC}");



            // Test GetHashCode method (studentA and studentB should output the exact same integer)
            Console.WriteLine($"\nstudentA HashCode: {studentA.GetHashCode()}");
            Console.WriteLine($"studentB HashCode: {studentB.GetHashCode()}");
            Console.WriteLine($"studentC HashCode: {studentC.GetHashCode()}");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}