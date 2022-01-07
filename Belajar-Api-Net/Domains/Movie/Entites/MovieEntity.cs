using Belajar_Api_Net.Infrastructures.DataAccess;
using System.ComponentModel.DataAnnotations.Schema;

namespace Belajar_Api_Net.Domains.Movie.Entites
{
    [Table("Movies")]
    public class MovieEntity : BaseEntity
    {
        [Column("id")]
        public Guid id { get; set; }

        [Column("title")]
        public string title { get; set; }

        [Column("overview")]
        public string overview { get; set; }

        [Column("poster")]
        public string poster { get; set; }


    }
}
