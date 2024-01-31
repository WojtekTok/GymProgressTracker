using GymProgressTracker.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProgressTracker.Repositories
{
    public interface IExerciseRepository
    {
        public List<Exercise> GetExercises();
        public void AddExercise(Exercise exercise);
    }
}
