using Codecool.GradingSystem.Repository;

namespace Codecool.GradingSystem.Ui;

public class GetExamsUi
{
    private readonly IExamRepository _examRepository;

    public GetExamsUi(IExamRepository examRepository)
    {
        // _examRepository = ExamRepository.GetInstance();
        _examRepository = examRepository;
    }

    public void ShowExams()
    {
        var exams = _examRepository.GetExams().ToList();
        
        if (!exams.Any())
        {
            Console.WriteLine("No exams in the database.");
        }

        foreach (var exam in exams)
        {
            Console.WriteLine(exam);
        }
    }
}