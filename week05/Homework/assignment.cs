public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getter for student name (optional if needed in derived class)
    public string GetStudentName()
    {
        return _studentName;
    }

    // Getter for topic (optional if needed in derived class)
    public string GetTopic()
    {
        return _topic;
    }

    // Common summary method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
