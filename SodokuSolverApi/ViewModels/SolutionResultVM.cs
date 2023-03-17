using Newtonsoft.Json;

namespace SudokuSolverApi.ViewModels
{
    public class SolutionResultVM
    {
        public Guid SolutionResultId { get; set; }
        public int SolutionStatus { get; set; }
        [JsonIgnore]
        public string SolutionStatusDisplay { get; set; }
        public DateTime ResultDate { get; set; }

    }
}
