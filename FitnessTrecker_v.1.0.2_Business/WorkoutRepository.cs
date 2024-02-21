using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTrecker_v._1._0._2_Business.Interfaces;
using FitnessTreker_v1._0._2_OLYU.Models;
using Telegram.Bot.Types;

namespace FitnessTrecker_v._1._0._2_Business
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private Gym context;
        public WorkoutRepository(Gym context) { this.context = context; }

        public void DeleteWorkout(int workoutId)
        {
            Workout workout = context.Find<Workout>(workoutId);
            context.Workouts.Remove(workout);
           // throw new NotImplementedException();
        }

        public IEnumerable<Workout> GetAllWorkouts()
        {
            return context.Workouts.ToList();
            // throw new NotImplementedException();
        }

        public Workout GetWorkoutById(int workoutId)
        {
            return context.Workouts.Find(workoutId);
            // throw new NotImplementedException();
        }

        public void InsertWorkout(Workout workout)
        {
             context.Workouts.Add(workout);
            //throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
           // throw new NotImplementedException();
        }

        public void UpdateWorkout(Workout workout)
        {
            context.Update(workout);
            // throw new NotImplementedException();
        }
    }
}
