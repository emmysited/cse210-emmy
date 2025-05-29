public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor: Calls base constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Unique method for WritingAssignment
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
