namespace Codecool.GradingSystem.Model;

public record Exam(DateTime Date, string StudentName, string ExamName, Grade Grade)
{
    public override string ToString()
    {
        return
            $"{nameof(Date)}: {Date.ToShortDateString()}, {nameof(StudentName)}: {StudentName}, {nameof(ExamName)}: {ExamName}, {nameof(Grade)}: {Grade}";
    }
}