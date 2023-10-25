using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Model
{
    internal class Student : Person
    {
        public int p_studentID;
        public Student(int studentID, string Name, int Id, float math, float physic) : base (Name, Id, math, physic)
        {
            this.p_studentID = studentID;
        }
        public Student()
        { 

        }

        public override void InputInformation()
        {
            Console.WriteLine("Input Student ID: ");
            p_studentID = int.Parse(Console.ReadLine());
            base.InputInformation();
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
