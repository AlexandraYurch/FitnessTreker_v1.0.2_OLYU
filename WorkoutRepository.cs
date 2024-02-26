using FitnessTrecker_Domain.Interfaces;
using FitnessTreker_Domain.Models;
using FitnessTreker_Domain.Data;

namespace FitnessTrecker_Domain
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
