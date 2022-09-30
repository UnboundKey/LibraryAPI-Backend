using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Series
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string logoImg { get; set; }
        public ICollection<BookToSeries> Books { get; set; }
    }
}
