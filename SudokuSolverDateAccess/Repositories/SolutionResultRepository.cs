
using SudokuSolver.Model;
using SudokuSolver.UserCases;

namespace SudokuSolver.DataAccess.Repositories
{
    public class SolutionResultRepository : ISolutionResultRepository
    {
        private readonly SudokuSolverDbContext db;

        public SolutionResultRepository(SudokuSolverDbContext db)
        {
            this.db = db;
        }

        public void AddSolutionResult(SolutionResultDM solutionResultDM)
        {
            db.SolutionResults.Add(solutionResultDM);
            db.SaveChanges();
        }

        public IEnumerable<SolutionResultDM> GetSolutionResults()
        {
            return db.SolutionResults.Where(m => !m.IsDeleted).ToList();
        }
    }
}
