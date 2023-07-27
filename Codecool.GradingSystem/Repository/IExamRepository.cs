using Codecool.GradingSystem.Model;

namespace Codecool.GradingSystem.Repository;

public interface IExamRepository
{
    void AddExam(Exam exam);
    IEnumerable<Exam> GetExams();
}