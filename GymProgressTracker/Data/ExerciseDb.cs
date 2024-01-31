using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymProgressTracker.MVVM.Models;

namespace GymProgressTracker.Data
{
    internal class ExerciseDb : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }
    }
}
