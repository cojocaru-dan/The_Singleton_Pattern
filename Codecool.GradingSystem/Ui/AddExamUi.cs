using Codecool.GradingSystem.Model;
using Codecool.GradingSystem.Repository;

namespace Codecool.GradingSystem.Ui;

public class AddExamUi
{
    private readonly ExamRepository _examRepository;

    public AddExamUi()
    {
        _examRepository = new ExamRepository();
    }

    public void AddExam()
    {
        var examDate = GetExamDate();
        var studentName = GetStudentName();
        var examName = GetExamName();
        var examGrade = GetExamGrade();
        
        _examRepository.AddExam(new Exam(examDate, studentName, examName, examGrade));
        
        Console.WriteLine("Exam added.");
    }
    
    public static DateTime GetExamDate()
    {
        Console.Write("Exam date: ");
        return DateTime.Parse(Console.ReadLine());
    }
    
    public static string GetStudentName()
    {
        Console.Write("Student name: ");
        return Console.ReadLine();
    }
    
    public static string GetExamName()
    {
        Console.Write("Exam name: ");
        return Console.ReadLine();
    }
    
    public static Grade GetExamGrade()
    {
        Console.Write("Exam grade: ");
        return (Grade)Enum.Parse(typeof(Grade), Console.ReadLine());
    }

}