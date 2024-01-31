using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProgressTracker.ViewModels
{
    class ShellViewModel : Screen
    {
        public ExerciseViewModel ExerciseViewModel { get; set; }

        public ShellViewModel()
        {
            this.ExerciseViewModel = new ExerciseViewModel();
        }
    }
}
