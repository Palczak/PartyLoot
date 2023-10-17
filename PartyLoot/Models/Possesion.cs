using System.ComponentModel.DataAnnotations;

namespace PartyLoot.Models
{
    public class Possesion
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Item Item { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Player? CurrentOwner { get; set; }
        [MaxLength(200)]
        public string? ObtainingComment { get; set; }
        [Required]
        public DateTime ObtainedUtc { get; set; }
    }
}
