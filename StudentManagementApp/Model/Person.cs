using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Model
{
    internal class Person : Object
    {
        public string p_Name { get; set; }
        public int p_Id { get; set; }
        public float p_Math { get; set; }
        public float p_Physic { get; set; }

        public Person(string name, int id, float math, float physic)
        {
            p_Name = name;
            p_Id = id;
            p_Math = math;
            p_Physic = physic;
        }

        public Person()
        {

        }



        public virtual void InputInformation()
        {
            Console.WriteLine("Input ID: ");
            p_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Name: ");
            p_Name = Console.ReadLine();
            Console.WriteLine("Input Math grade: ");
            p_Math = float.Parse(Console.ReadLine());
            Console.WriteLine("Input Physic grade: ");
            p_Physic = float.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Id: " + p_Id);
            Console.WriteLine("Name: " + p_Name);
            Console.WriteLine("Math: " + p_Math);
            Console.WriteLine("Physic: " + p_Physic);
        }
    }
}
