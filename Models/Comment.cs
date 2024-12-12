using System.ComponentModel.DataAnnotations.Schema;

namespace Moviey_Back.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string  Review { get; set; }

        [ForeignKey("ProductId")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
