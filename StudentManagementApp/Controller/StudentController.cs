using StudentManagementApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Controller
{
    internal class StudentController
    {
        private ArrayList p_studentList;

        

        public StudentController()
        {
            p_studentList = new ArrayList();
        }

        public void AddStudent()
        {
            Student add_student = new Student();
            add_student.InputInformation();
            p_studentList.Add(add_student);
        }

        public void DisplayMenu()
        {
            foreach (Student student in p_studentList) 
            {
                student.Display();
            }
            int choices;
            try
            {
                Console.WriteLine("\n 1. Sort by ID");
                Console.WriteLine("\n 2. Sort by Name");
                Console.WriteLine("\n 3. Return");
                choices = Convert.ToInt32(Console.ReadLine());
                switch(choices)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        SortID();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();
                        SortName();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Back to Main Menu");
                        return;
                    default:
                        break;

                }
            } 
            catch (Exception)
            {
                Console.WriteLine("Invalid choices");
            }

        }

        public void SearchMenu()
        {
            int choices;
            try
                {
                Console.WriteLine("\n 1. Find by ID");
                Console.WriteLine("\n 2. Find by Name");
                Console.WriteLine("\n 3. Return");
                choices = Convert.ToInt32(Console.ReadLine());
                switch(choices)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        FindbyID(id);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();
                        FindbyName(name);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Back to Main Menu");
                        return;
                    default: 
                        break;
                }
            } 
            catch (Exception)
            {
                Console.WriteLine("Invalid choices");
            }
        }

        public void UpdateMenu()
        {
            int choices;
            try
            {
                Console.WriteLine("\n 1. Update by ID");
                Console.WriteLine("\n 2. Update by Name");
                Console.WriteLine("\n 3. Return");
                choices = Convert.ToInt32(Console.ReadLine());
                switch(choices) 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        UpdateByID(id);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();
                        UpdateByName(name);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Back To Main Menu");
                        return;
                    default:
                        break;
                }
            }
            catch (Exception) 
            {
                Console.WriteLine("Invalid choices");
            }
        }

        public void DeleteMenu()
        {
            int choices;
            try
            {
                Console.WriteLine("\n 1. Delete by ID");
                Console.WriteLine("\n 2. Delete by Name");
                choices = Convert.ToInt32(Console.ReadLine());
                switch (choices) 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter ID");
                        int id = int.Parse(Console.ReadLine());
                        DeletebyID(id);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        DeleteByName(name);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Back to Main Menu");
                        return;
                    default: break;
                }
            }
                catch (Exception) 
            {
                Console.WriteLine("Invalid choices");
            }
        }


        public void FindbyID(int id)
        {
            bool found = false;
            foreach (Student student in p_studentList) 
            {
                if(student.p_studentID == id) 
                {
                    student.Display();
                    found = true;
                    break;
                } else
                {
                    Console.WriteLine("Invalid ID: " + id);
                }

            }
        }

        public void FindbyName(string name) 
        {
            bool found = false;
            foreach(Student student in p_studentList)
            {
                if(student.p_Name == name)
                {
                    student.Display(); 
                    found = true;
                    break;
                }
                else
                {
                    Console.WriteLine("There is no student with name: " + name);
                }
            }
        }

        public void SortID()
        {

        }

        public void SortName() 
        {

        }

        

        public void UpdateByID(int id) 
        {
            foreach(Student student in p_studentList)
            {
                if(student.p_studentID == id)
                {
                    Console.WriteLine("Please enter new name: ");
                    student.p_Name = Console.ReadLine();
                    Console.WriteLine("Please enter new Math grade: ");
                    student.p_Math = float.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter new Physic grade: ");
                    student.p_Physic = float.Parse(Console.ReadLine());
                } else
                {
                    Console.WriteLine("There is no Student with ID: " + id);
                }
            }
        }

        public void UpdateByName(string name) 
        {
            foreach (Student student in p_studentList)
            {
                if(student.p_Name == name)
                {
                    Console.WriteLine("Please enter new name: ");
                    student.p_Name = Console.ReadLine();
                    Console.WriteLine("Please enter new Math grade: ");
                    student.p_Math = float.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter new Physic grade: ");
                    student.p_Physic = float.Parse(Console.ReadLine());
                } else
                {
                    Console.WriteLine("There is no Student with Name: " + name);
                }
            }
        }

        public void DeletebyID(int id)
        {
            foreach (Student student in p_studentList)
            {
                if (student.p_studentID == id)
                {
                    p_studentList.Remove(student.p_studentID);
                }
            }
        }
        public void DeleteByName(string name) 
        {
            foreach(Student student in p_studentList)
            {
                if( student.p_Name == name)
                {
                    p_studentList.Remove(student.p_Name);
                }
            }
        }

    }
}
