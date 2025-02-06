using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Challenge1
{
    internal class Program
    {
        static List<Student> student = new List<Student>();

        static void Main(string[] args)
        {
            int option = Menu();
            while (option!=5)
            {
              switch (option)
                {
                    case 1:
                          string result = AddStudent();
                          Console.WriteLine(result);
                        
                        break;

                    case 2:
                        showStudent();
                       
                        break;
                    case 3:
                        aggregate();
                        break;

                    case 4:

                        topStudents();

                        break;
                    default:
                        Console.WriteLine("Exiting the program");
                        break;
                }
                Console.ReadKey();
                option = Menu();
               
            }
        }
    

        static  public string AddStudent()
        {
           
            string name;
            float matricmarks, fscMarks, ecatMarks;
          
            Console.WriteLine("Welcome to the student interface");
            Console.WriteLine();
            Console.WriteLine("Enter Student Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Matric Marks");
            matricmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Fsc MArks");
            fscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Ecat Marks");
            ecatMarks = float.Parse(Console.ReadLine());
            Student str = new Student(name,matricmarks,fscMarks,ecatMarks);
            student.Add(str);
            return "Student added sucessfully:";
            
        }
        static public void  aggregate()
        {
            
            if (student.Count == 0)
            {
                Console.WriteLine("No student found.");
            }
            else
            {
                foreach (Student s in student)
                {
                    Console.WriteLine($" The name  {s.sname} has aggregate : {s.Aggregate}");
                }
            }
        }
         static public void showStudent()
        {
           
            Console.WriteLine("The top students interface is");
            if (student.Count == 0)
            {
                Console.WriteLine("No Students registered:");
            }
            else
            {
                foreach (Student student in student)
                {
                    student.showStudents();
                }
            }

        }
        static  int Menu()
        {
            Console.Clear();
            Console.WriteLine("1-Add Student");
            Console.WriteLine("2-Show Students");
            Console.WriteLine("3-Calculate Aggregate");
            Console.WriteLine("4-Top Students");
            Console.WriteLine("5-Exit");
            int choice;
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static public void topStudents()
        {
           
            var topstudents = new List<Student>(student);
            topstudents.Sort((s1,s2) => s2.Aggregate.CompareTo(s1.Aggregate));
            foreach (Student student in topstudents)
            {
                Console.WriteLine($"{student.sname} has {student.Aggregate}");
            }

        }
        
    }
}
