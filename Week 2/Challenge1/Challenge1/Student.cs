using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenge1
{
    internal class Student
    {
       
            public string sname;
            public float Matricmarks;
            public float FscMarks;
            public float EcatMarks;
            public float Aggregate;
            public Student(string name, float matricmarks, float fscMarks, float ecatMarks)
            {
                sname = name;
                Matricmarks = matricmarks;
                FscMarks = fscMarks;
                EcatMarks = ecatMarks;
                aggregate();

            }
      
        public void aggregate()
        {
             Aggregate = ((Matricmarks / 1100) * 25) + ((FscMarks / 1200) * 45) + ((EcatMarks / 400) * 30);
        }
        public void showStudents()
        {
            Console.WriteLine($"Name:{sname},Matric Marks:{Matricmarks},FSC Marks:{FscMarks},Ecat Marks:{EcatMarks},and Aggregate : {Aggregate}");
        }
        
    }
}
