using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Anna", "Peteyan", new DateTime(2000, 9, 9));
            person.Show();

            //Person person2 = new Person();
            //person2._name = "Petja";
            //person2.Show();

            /// Exam e = new Exam ("Cate", 5, new DateTime(2022, 5, 5));
            /// e.Show();

          //  Student student = new Student("High", 18, "Math Done");
           // student.Show();

       //     string Name = student2.Education;
           // double asd = student2.averageScore;

            Exam exams = new Exam("Geography", 4, new DateTime(2022, 12, 12));
            Exam exams2 = new Exam("Math", 2, new DateTime(2022, 12, 6));
            Student student2 = new Student("rfuvsyio", 38,new[]{ exams, exams2 });
            student2.Education = "PIB";
            double avg = student2.averageScore;
        }
    }
}


  

    