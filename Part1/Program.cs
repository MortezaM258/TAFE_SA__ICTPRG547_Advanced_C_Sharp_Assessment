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


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}