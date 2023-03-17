using SudokuSolver.Model;

namespace SudokuSolver.UserCases
{
    public interface IAddSolutionResultUseCase
    {
        void Execute(SolutionResultDto solutionResultDM);
    }
}
