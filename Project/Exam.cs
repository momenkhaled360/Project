using System;
using System.Collections.Generic;

public abstract class Exam
{
    public int Time { get; set; }
    public int NumberOfQuestions { get; set; }
    public List<Question> Questions { get; set; }

    public Exam(int time, int number)
    {
        Time = time;
        NumberOfQuestions = number;
        Questions = new List<Question>();
    }

    public abstract void ShowExam();
}

