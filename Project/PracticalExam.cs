using System;

public class PracticalExam : Exam
{
    public PracticalExam(int time, int number) : base(time, number) { }

    public override void ShowExam()
    {
        Console.WriteLine("=== Practical Exam ===");
        foreach (var q in Questions)
        {
            q.Show();
            Console.WriteLine($"Right Answer: {q.RightAnswerId}\n");
        }
    }
}

