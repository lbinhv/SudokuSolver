using SudokuSolver.Model;

namespace SudokuSolver.UserCases
{
    public interface IViewSolutionResultUseCase
    {
        IEnumerable<SolutionResultDM> Execute();
    }
}
