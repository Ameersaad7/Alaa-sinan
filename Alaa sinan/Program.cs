using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaa_sinan
{
public class Student
    {
        private string name;
        private string address;
        private double mark;

        public Student(string name, string address, double mark)
        {
            this.name = name;
            this.address = address;
            this.mark = mark;
        }

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
        }

        public double Mark
        {
            get { return mark; }
        }
    }

    public class StudentPrinter
    {
        public void PrintStudentInfo(Student student)
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Mark: " + student.Mark);
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student("Ameer", "shaab", 99);

            StudentPrinter printer = new StudentPrinter();

            printer.PrintStudentInfo(student);
            Console.ReadLine();
        }
    }      
}
