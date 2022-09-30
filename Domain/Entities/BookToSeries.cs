using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BookToSeries
    {
        public int BookId { get; set; }
        public Book Book;
        public int SeriesId { get; set; }
        public Series Series { get; set; }


    }
}
