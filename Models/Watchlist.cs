using System.ComponentModel.DataAnnotations.Schema;

namespace Moviey_Back.Models
{
    public class Watchlist
    {
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
