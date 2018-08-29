using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEFCoreCodeFirst.PL
{
    class Actor
    {
        public int ActorId { get; set; }
        public DateTime DateBirth { get; set; }
        public string Name { get; set; }
        public ICollection<ActorMovie> ActorMoviesList { get; set; }
    }
}
