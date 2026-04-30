public class Student
{
    public int StudentID { get; set; }
    public string StudentFirstName { get; set; }
    public string StudentLastName { get; set; }
    public double MidTermScore { get; set; }
    public double FinalScore { get; set; }

    public Student(int studentId, string studentFirstName, string studentLastName, double midTermScore, double finalScore)
    {
        StudentID = studentId;
        StudentFirstName = studentFirstName;
        StudentLastName = studentLastName;
        MidTermScore = midTermScore;
        FinalScore = finalScore;
    }
}