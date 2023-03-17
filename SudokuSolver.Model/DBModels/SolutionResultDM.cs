using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SudokuSolver.Model
{
    public class SolutionResultDM
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SolutionResultId { get; set; }
        [Required]
        public int SolutionStatus { get; set; }
        [Required]
        public DateTime SolutionDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
