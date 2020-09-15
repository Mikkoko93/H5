using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork5.Models;

namespace HomeWork5.Repositories
{
    public class EntriesRepository
    {
        public static EntriesRepository Instance { get; } = new EntriesRepository();

        public List<Entry> entries;




        public void AddDummyEntries()
        {
            AddEntry(Exercise.Walking, 60);
            AddEntry(Exercise.Running, 30);
            AddEntry(Exercise.Gym, 90);
            AddEntry(Exercise.Badminton, 45);
        }

        public void AddEntry(Exercise exercise, int duration)
        {
            Entry entry = new Entry
            {
                ExerciseType = exercise,
                Date = DateTime.Now,
                Duration = duration
            };

        }
        public List<Entry> GetEntries()
        {
            return entries;
        }
    }
}
