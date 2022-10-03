using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? title { get; set; }
        public string? original_title { get; set; }
        [Column(TypeName = "text")]
        public string? description { get; set; }
        public string? short_description { get; set; }
        public string? coverImg { get; set; }
        public string? author { get; set; }
        public string? author_romanized { get; set; }
        public string? ISBN { get; set; }
        public string? firstPrinted { get; set; }
        public string? printing { get; set; }
        public string? genre { get; set; }
        public string? language { get; set; }
        public string? bookType { get; set; }
        public string? review { get; set; } = "";

        // linking object
        public ICollection<BookToSeries> Series { get; set; }
    }
}
