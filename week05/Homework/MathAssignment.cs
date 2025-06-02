using System.Configuration.Assemblies;

public class MathAssignment(string name, string topic, string textbookSection, string problems) : Assignment(name, topic)
{
    private string _textbookSection = textbookSection;
    private string _problems = problems;

    // public MathAssignment(string name, string topic ,string textbookSection, string problems) : base(name, stuTopic)
    // {
    //     _textbookSection = "1";
    // }

    // public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, stuTopic)
    // {
    //     _textbookSection = textbookSection;
    //     _problems = problems;

    // }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }
}