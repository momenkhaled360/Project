using System;

public class FinalExam : Exam
{
    public FinalExam(int time, int number) : base(time, number) { }

    public override void ShowExam()
    {
        Console.WriteLine("=== Final Exam ===");
        int total = 0;
        foreach (var q in Questions)
        {
            q.Show();
            Console.Write("Enter your answer: ");
            int userAns = int.Parse(Console.ReadLine());
            if (userAns == q.RightAnswerId)
                total += q.Mark;
        }
        Console.WriteLine($"Your Grade: {total}/{Questions.Count * 10}");
    }
}
