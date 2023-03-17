using Microsoft.EntityFrameworkCore;
using SudokuSolver.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.DataAccess
{
    public class SudokuSolverDbContext : DbContext
    {
        public DbSet<SolutionResultDM> SolutionResults { get; set; }

        public SudokuSolverDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SolutionResultDM>()
                        .ToTable("SolutionResults")
                        .HasKey(i => i.SolutionResultId);
        }
    }
}
