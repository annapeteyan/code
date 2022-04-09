using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exam
{
    public
    string name;
     public int grade;
    System.DateTime examDate;


    public Exam(string name, int grade, System.DateTime examDate)
    {
        this.name = name;
        this.grade = grade;
        this.examDate = examDate;

     

    }
    public void Show()
    {
        Console.WriteLine(name + " got" + grade + " for exam");
    }
    //string ToFullString()
    //{ }
}