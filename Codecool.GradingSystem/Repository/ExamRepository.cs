using Codecool.GradingSystem.Model;

namespace Codecool.GradingSystem.Repository;

public class ExamRepository : IExamRepository
{
    private readonly List<Exam> _exams = new();
    
    public void AddExam(Exam exam)
    {
        _exams.Add(exam);
    }
    
    public IEnumerable<Exam> GetExams()
    {
        return _exams;
    }
    
}