
var questions = new List<SurveyQuestion>
{
    new SurveyQuestion("Q1", 1)
};

var q2 = new SurveyQuestion("Q2", 2);

questions.Add(q2);

foreach (var q in questions)
{
    // Nullable
    var hint = q.QuestionHint == null ? string.Empty : $"(hint: {q.QuestionHint})";

    Console.WriteLine($"{q.QuestionText}, {hint}");
}

public class SurveyQuestion
{
    public SurveyQuestion(string text, int number) =>
        (QuestionNumber, QuestionText) = (number, text);

    public string QuestionText { get; }

    public int QuestionNumber { get; }

    public string? QuestionHint { get; }

}


