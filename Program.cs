using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace InheritanceAssignmentDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(101, "Bhargavi", "Banglore", 987654321, "final year", 930000, "A", 60000);
            Console.WriteLine("Student Information:");
            s.DisplayPersonInfo();
            Console.WriteLine();

            TeachingStaff t = new TeachingStaff(201, "Arjun", "Hyderabad", 9087523456, "professor", 50000, "ph.D", "Mathematics");
            Console.WriteLine("Teaching Staff Information:");
            t.DisplayPersonInfo();
            Console.WriteLine();

            NonTeachingStaff nt = new NonTeachingStaff(202, "Chandrika", "Pune", 334560982, "lab technician", 200000, "b.tech", "Electonic and communication", 2929);
            Console.WriteLine("Non teaching staff Information:");
            nt.DisplayPersonInfo();
            Console.WriteLine();
        }
    }
}
