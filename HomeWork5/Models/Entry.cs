using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork5.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Exercise ExerciseType { get; set; }
        public int Duration { get; set; }
    }
}
