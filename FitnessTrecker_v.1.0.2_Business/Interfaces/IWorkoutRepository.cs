using FitnessTreker_v1._0._2_OLYU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrecker_v._1._0._2_Business.Interfaces
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
