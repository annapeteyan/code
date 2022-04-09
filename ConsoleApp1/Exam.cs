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
    public void Add(int[] arr2)
    {
        int sumLength = arr.Length + arr2.Length;
        int[] tmp = new int[sumLength];
        for (int i = 0; i < arr2.Length; i++)
        {
            tmp[i] = arr2[i];

        }
        arr3 = tmp;

        for(int i = arr + arr2; i<arr2.Length; i++)
        { tmp[i] = arr2;                                                         

        }



    public string ToFullString()
    {
        return (name + " " + grade + " " + examDate + " " + exams);


    }
    public string ToShortString() 
    {
        return (name + " " + grade + " " + examDate + " " + averageScore);

    }