using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var listStudents = new List<Student>();

            for (int i = 1; i <= 10; i++)
            {
                var fullName = "Bezunov " + i;
                var educationFrom = GetEducation();
                var birthday = new DateTime(2003, 5, 27).AddMonths(rnd.Next(1, 5)).AddDays(rnd.Next(-20, 20));
                var groupId = rnd.Next(100, 999);
                listStudents.Add(new Student(fullName, educationFrom, birthday, groupId));
            }

            Console.WriteLine("Все студенты:");
            OutputList(listStudents);

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("A - Показать Specialist.");
                Console.WriteLine("S - Показать Вachelor.");
                Console.WriteLine("E - Показать SecondEducation.");
                Console.WriteLine("D - Показать всех.");
                Console.WriteLine("Q - Выход.");
                Console.ForegroundColor = ConsoleColor.Green;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        OutputList(listStudents.Where(s => s.EducationFrom == Education.Specialist).ToList());
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        OutputList(listStudents.Where(s => s.EducationFrom == Education.Вachelor).ToList());
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        OutputList(listStudents.Where(s => s.EducationFrom == Education.SecondEducation).ToList());
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        OutputList(listStudents);
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        flag = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такой команды нет.");
                        break;
                }
            }


            Console.ReadLine();
        }

        private static void OutputList(List<Student> list)
        {
            Console.WriteLine();
            if (list.Count > 0)
            {
                Console.WriteLine("_________________________________________________________");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("_________________________________________________________");
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
            Console.WriteLine();
        }

        private static Education GetEducation()
        {   
            switch (rnd.Next(1,3))
            {
                case 1:
                    return Education.Specialist;
                case 2:
                    return Education.Вachelor;
                case 3:
                    return Education.SecondEducation;
                default:
                    return Education.Specialist;
            }
        }
    }
}
