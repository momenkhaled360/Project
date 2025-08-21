using System;

public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion(string header, string body, int mark)
        : base(header, body, mark)
    {
        AnswerList.Add(new Answer(1, "True"));
        AnswerList.Add(new Answer(2, "False"));
    }

    public override void Show()
    {
        Console.WriteLine(ToString());
        foreach (var ans in AnswerList)
        {
            Console.WriteLine(ans);
        }
    }
}
