using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Student
    {
        string education;
        int groupNumber;
        Exam[] exams;
        //Person person;

        public string Education { get { return education; } set { education = value; } }
        public int GroupNumber { get { return groupNumber; } set { groupNumber = value; } } 
        public Exam[] Exams { get { return exams; } set { exams = value; } }
        public double averageScore
        {
            get
            {

              double averageScore = 0;
                foreach (Exam exam in exams)
                    averageScore += exam.grade;
                averageScore=  averageScore / exams.Length;
                




                return averageScore;


            }
        }
         

        //public Person Person { get { return person; } set { } }

        public Student(string education, int groupNumber, Exam[] exams)
        {
            this.education = education;
            this.groupNumber = groupNumber;
            this.exams = exams;
        }
        public Student()
        {
            this.education = "no name";
            this.groupNumber = 88;
            this.exams = null;
        }
        void AddExams
            (Exam[] exams)
        { this.exams = exams; }    

    }
   
}

