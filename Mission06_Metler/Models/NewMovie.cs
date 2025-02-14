using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Metler.Models
{
    public class NewMovie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto Increment
        public int Id { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        public string Notes { get; set; }
    }
}
