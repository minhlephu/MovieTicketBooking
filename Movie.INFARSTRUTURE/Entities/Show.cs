using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.INFARSTRUTURE.Entities
{
    public class Show
    {
        public Guid show_id { get; set;}
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public DateTime show_date { get; set; }
        public Guid mv_id { get; set; }
        public int mv_type_id { get; set; }
        public Movie movie { get; set; }
        public Movie_type movie_type { get; set; }

    }
}
