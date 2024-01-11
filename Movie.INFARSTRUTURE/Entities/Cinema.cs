using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.INFARSTRUTURE.Entities
{
    public class Cinema
    {
        public int cenima_id { get; set; }
        public string cenima_name { get; set; }
        public string cenima_address { get; set; }
        public string cenima_tel { get; set; }
        public string cenima_email { get; set; }
        public City city { get; set; }
    }
}
