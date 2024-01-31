using Caliburn.Micro;
using GymProgressTracker.MVVM.Models;
using System;
using System.Collections.ObjectModel;
using GymProgressTracker.Data;
using GymProgressTracker.Repositories;

namespace GymProgressTracker.ViewModels
{ 
    public class ExerciseViewModel : Screen
    {
        private ObservableCollection<Exercise>? _exercises;
        private DateTime _date;
        private string _exerciseName="tak";
        private int _repetitions=2;
        private int _sets=11;
        private double _weight = 10;
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseViewModel()
        {
            WorkoutDate = DateTime.Now;
            _exerciseRepository = new ExerciseRepository();
            GetExercises();
        }

        public ObservableCollection<Exercise> Exercises
        {
            get { return _exercises; }
            set
            {
                _exercises = value;
                NotifyOfPropertyChange(() => Exercises);
            }
        }

        public DateTime WorkoutDate
        {
            get { return _date; }
            set
            {
                _date = value;
                NotifyOfPropertyChange(() => WorkoutDate);
            }
        }

        public string ExerciseName
        {
            get { return _exerciseName; }
            set
            {
                _exerciseName = value;
                NotifyOfPropertyChange(() => ExerciseName);
            }
        }

        public int Repetitions
        {
            get { return _repetitions; }
            set
            {
                _repetitions = value;
                NotifyOfPropertyChange(() => Repetitions);
            }
        }

        public int Sets
        {
            get { return _sets; }
            set
            {
                _sets = value;
                NotifyOfPropertyChange(() => Sets);
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                NotifyOfPropertyChange(() => Weight);
            }
        }

        public void AddCurrentExercise()
        {
            var exercise = new Exercise
            {
                Date = WorkoutDate,
                Name = ExerciseName,
                Repetitions = Repetitions,
                Sets = Sets,
                Weight = Weight
            };
            _exerciseRepository.AddExercise(exercise);

            // Clear input fields after adding exercise
            ExerciseName = string.Empty;
            Repetitions = 0;
            Sets = 0;
            Weight = 0.0;
            GetExercises();
        }

        public void GetExercises()
        {
            var exercisesFromDatabase = _exerciseRepository.GetExercises();

            Exercises = new ObservableCollection<Exercise>(exercisesFromDatabase);
        }
    }
}