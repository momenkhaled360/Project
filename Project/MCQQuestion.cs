using System;

public class MCQQuestion : Question
{
    public MCQQuestion(string header, string body, int mark)
        : base(header, body, mark) { }

    public override void Show()
    {
        Console.WriteLine(ToString());
        foreach (var ans in AnswerList)
        {
            Console.WriteLine(ans);
        }
    }
}
