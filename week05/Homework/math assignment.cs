public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor: Calls base constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Unique method for MathAssignment
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
