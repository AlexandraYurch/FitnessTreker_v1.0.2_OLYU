using FitnessTreker_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrecker_Domain.Interfaces
{
    public interface IWorkoutRepository
    {
        Workout GetWorkoutById(int workoutId);
        void InsertWorkout(Workout workout);
        void DeleteWorkout(int workoutId);
        void UpdateWorkout(Workout workout);
        IEnumerable<Workout> GetAllWorkouts();
        void Save();
    }
}
