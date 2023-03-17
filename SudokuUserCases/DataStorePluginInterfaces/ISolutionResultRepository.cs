using SudokuSolver.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.UserCases
{
    public interface ISolutionResultRepository
    {
        IEnumerable<SolutionResultDM> GetSolutionResults();
        void AddSolutionResult(SolutionResultDM solutionResultDM);
    }
}
