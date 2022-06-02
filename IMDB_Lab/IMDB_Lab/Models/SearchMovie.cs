using System.ComponentModel.DataAnnotations;

namespace IMDB_Lab.Models
{
    public class SearchMovie
    {
        [Required]
        public string SearchTerm { get; set; }
    }
}
