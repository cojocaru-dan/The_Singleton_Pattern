namespace Codecool.GradingSystem.Ui;

public class UiSelector
{
    private readonly AddExamUi _addExamUi;
    private readonly GetExamsUi _getExamsUi;

    public UiSelector()
    {
        _addExamUi = new AddExamUi();
        _getExamsUi = new GetExamsUi();
    }

    public void SelectUi()
    {
        Console.WriteLine("Select a UI to show: 1 - Add exam, 2 - View exams, 3 - Exit");
        var input = Console.ReadLine();
        
        switch (input)
        {
            case "1":
                _addExamUi.AddExam();
                SelectUi();
                break;
            case "2":
                _getExamsUi.ShowExams();
                SelectUi();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input.");
                SelectUi();
                break;
        }
    }
}