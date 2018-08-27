using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEFCoreCodeFirst.PL
{
    class ActorMovie
    {
        public int ActorId { get; set; }
        public string Character { get; set; }
        public int MovieId { get; set; }
        public ICollection<Actor> Actors { get; set; }
    }
}
