using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProgressTracker.MVVM.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set; }
        public double Weight { get; set; }
    }
}
