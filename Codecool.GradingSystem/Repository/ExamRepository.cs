using Codecool.GradingSystem.Model;

namespace Codecool.GradingSystem.Repository;

public class ExamRepository : IExamRepository
{
    private readonly List<Exam> _exams = new();
    // private static ExamRepository _instance;

    public void AddExam(Exam exam)
    {
        _exams.Add(exam);
    }
    
    public IEnumerable<Exam> GetExams()
    {
        return _exams;
    }
    // public static ExamRepository GetInstance()
    // {
    //     _instance ??= new ExamRepository();
    //     return _instance;
    // }

}