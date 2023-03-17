using SudokuSolver.Model;

namespace SudokuSolver.UserCases
{
    public class AddSolutionResultUseCase : IAddSolutionResultUseCase
    {
        private readonly ISolutionResultRepository _solutionResultRepository;

        public AddSolutionResultUseCase(ISolutionResultRepository solutionResultRepository)
        {
            this._solutionResultRepository = solutionResultRepository;
        }

        public void Execute(SolutionResultDto solutionResultDto)
        {
            var solutionResultDM = new SolutionResultDM
            {
                SolutionStatus = solutionResultDto.SolutionStatus,
                IsDeleted = false,
                SolutionDate = solutionResultDto.SolutionDate,
            };

            _solutionResultRepository.AddSolutionResult(solutionResultDM);
        }
    }
}
