
using SudokuSolver.Model;

namespace BusinessLogic.Service
{
    internal class SudokuSolverService : ISudokuSolverService
    {
        public IList<SolvedSudokuDto> GetListSodokuSolve()
        {
            var a = new List<SolvedSudokuDto>();

            return a;
        }

        public void AddSolutionResult(SolvedSudokuDto model)
        {
            var solutionResultDM = new SolutionResultDM { 
                SolutionStatus = model.SolutionStatus,
                IsDeleted = false,
                SolutionDate = model.SolutionDate,                
            }

        }
    }
}
