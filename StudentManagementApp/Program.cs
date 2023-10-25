using StudentManagementApp.Controller;

namespace StudentManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentController menu = new StudentController();
            int choices;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("===== Student Management System =====");
                        Console.WriteLine("\n 1.Add");
                        Console.WriteLine("\n 2.Display");
                        Console.WriteLine("\n 3.Search");
                        Console.WriteLine("\n 4.Update");
                        Console.WriteLine("\n 5.Delete");
                        Console.WriteLine("\n 6.Exit");
                        choices = Convert.ToInt32(Console.ReadLine());
                        switch (choices)
                        {
                            case 1:
                                menu.AddStudent();
                                break;
                            case 2:
                                menu.DisplayMenu();
                                break;
                            case 3:
                                menu.SearchMenu();
                                break;
                            case 4:
                                menu.UpdateMenu(); 
                                break;
                            case 5:
                                menu.DeleteMenu();
                                break;
                            case 6:
                                return;
                        }
                    } while (choices != 0);
                    break;
                }
                catch (Exception) 
                {
                    Console.WriteLine("Invalid Choices");
                }
            }
        }
    }
}