namespace PartyLoot.Models
{
    public class Possesion
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public Player? CurrentOwner { get; set; }
        public string? ObtainingContext { get; set; }
        public DateTime Obtained { get; set; }
    }
}
