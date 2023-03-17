using SudokuSolver.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.UserCases
{
    public class ViewSolutionResultUseCase : IViewSolutionResultUseCase
    {
        private readonly ISolutionResultRepository _solutionResultRepository;

        public ViewSolutionResultUseCase(ISolutionResultRepository solutionResultRepository)
        {
            _solutionResultRepository = solutionResultRepository;
        }

        public IEnumerable<SolutionResultDM> Execute()
        {
            return _solutionResultRepository.GetSolutionResults();
        }
    }
}
