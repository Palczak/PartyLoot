namespace PartyLoot.Models
{
    public class Party
    {
        public int Id { get; set; }
        public IList<Player> Players { get; set; } = new List<Player>();
        public IList<Possesion> Possesions { get; set; } = new List<Possesion>();
    }
}
