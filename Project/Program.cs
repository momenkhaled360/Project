using System;

class Program
{
    static void Main(string[] args)
    {
        Subject subj = new Subject(1, "OOP");

        // Create a Final Exam
        FinalExam finalExam = new FinalExam(60, 2);

        // Q1: 
        TrueFalseQuestion q1 = new TrueFalseQuestion("Q1", "C# is Object Oriented?", 10);
        q1.RightAnswerId = 1;

        // Q2:
        MCQQuestion q2 = new MCQQuestion("Q2", "Which is not OOP concept?", 10);
        q2.AnswerList.Add(new Answer(1, "Inheritance"));
        q2.AnswerList.Add(new Answer(2, "Encapsulation"));
        q2.AnswerList.Add(new Answer(3, "Compilation"));
        q2.RightAnswerId = 3;

        finalExam.Questions.Add(q1);
        finalExam.Questions.Add(q2);

        subj.CreateExam(finalExam);

        Console.WriteLine(subj);
        subj.SubjectExam.ShowExam();
    }
}
