using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymProgressTracker.Data;
using GymProgressTracker.MVVM.Models;

namespace GymProgressTracker.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private ExerciseDb _context;
        public ExerciseRepository()
        {
            _context = new ExerciseDb();
        }

        public List<Exercise> GetExercises()
        {
            List<Exercise> exercises = _context.Exercises.ToList();

            return exercises;
        }

        public void AddExercise(Exercise exercise)
        {
            _context.Exercises.Add(exercise);
            _context.SaveChanges();
        }
    }
}
