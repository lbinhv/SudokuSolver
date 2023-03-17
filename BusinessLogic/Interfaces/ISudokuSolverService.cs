using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface ISudokuSolverService
    {
        public IList<SolvedSudokuDto> GetListSodokuSolve();
        public void AddSolutionResult(SolvedSudokuDto model);
    }
}
