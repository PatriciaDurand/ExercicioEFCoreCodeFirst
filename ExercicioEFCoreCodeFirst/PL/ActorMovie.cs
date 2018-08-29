using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class ActorMovie
    {
        public int ActorMovieId { get; set; }
        public string Character { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }

    }
}
