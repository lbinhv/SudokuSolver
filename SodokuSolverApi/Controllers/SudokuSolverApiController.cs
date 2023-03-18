using Microsoft.AspNetCore.Mvc;
using SudokuSolver.Core;
using SudokuSolver.UserCases;
using SudokuSolverApi.ViewModels;

namespace SudokuSolverApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SudokuSolverApiController : ControllerBase
    {
        #region Variaables and Properties
        private IAddSolutionResultUseCase _addSolutionResultUseCase;
        private IViewSolutionResultUseCase _viewSolutionResultUseCase;
        #endregion

        #region Contructor
        public SudokuSolverApiController(IAddSolutionResultUseCase addSolutionResultUseCase
            , IViewSolutionResultUseCase viewSolutionResultUseCase)
        {
            _addSolutionResultUseCase = addSolutionResultUseCase;
            _viewSolutionResultUseCase = viewSolutionResultUseCase;
        }
        #endregion

        #region API Logic Methods

        [HttpGet]
        [Route("/GetListSolutionResult")]
        public IEnumerable<SolutionResultVM> Get()
        {
            var results = _viewSolutionResultUseCase.Execute().OrderByDescending(d => d.SolutionDate);

            var solutionResultVMs = results.Select(m => new SolutionResultVM
            {
                SolutionResultId = m.SolutionResultId,
                SolutionStatusDisplay = m.SolutionStatus == (int)SolutionStatusEnum.Success ? SolutionStatusEnum.Success.ToString() : SolutionStatusEnum.Failure.ToString(),
                ResultDate = m.SolutionDate
            }).ToList();

            return solutionResultVMs;
        }


        [HttpPost]
        [Route("/AddSolutionResult")]
        public IActionResult Post([FromBody] bool result)
        {
            try
            {
                var solutionResultDto = new SolutionResultDto
                {
                    SolutionStatus = result ? (int)SolutionStatusEnum.Success : (int)SolutionStatusEnum.Failure,
                    IsDeleted = false,
                    SolutionDate = DateTime.UtcNow,
                };
                _addSolutionResultUseCase.Execute(solutionResultDto);

                return Ok(new { message = "Data saved successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest($"Error saving data: {ex.Message}");
            }
        }
        #endregion
    }
}
