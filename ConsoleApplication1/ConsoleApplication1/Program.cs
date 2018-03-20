using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("shiweizhi");
            stu1.age = "23";
            Console.WriteLine(stu1.age);
            Console.ReadKey();
        }
    }

    class Student
    {
        public String name;
        public String age;
        String gender;
        String stu_id;

        public Student(String name)
        {
            this.name = name;
        }

    }
}
