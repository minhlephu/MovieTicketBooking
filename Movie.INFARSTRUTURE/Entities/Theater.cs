using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.INFARSTRUTURE.Entities
{
    public class Theater
    {
        public int theater_id { get; set; }
        public int row_qty { get; set; }
        public int col_qty { get; set; }
        public int end_cinema_id { get; set; }
      
    }
}
