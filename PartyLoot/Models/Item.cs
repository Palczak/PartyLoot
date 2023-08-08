namespace PartyLoot.Models
{
    public class Item
    {
        public string Name { get; set; }
        public Source Source { get; set; }
        public Rarity Rarity { get; set; }
        public string Type { get; set; }
        public string Attunement { get; set; }
        public string Properties { get; set; }
        public decimal WeightInOz { get; set; }
        public decimal ValueInGold { get; set; }
        public string Text { get; set; }
    }

    public enum Source
    {
        DMG,
        PHB,
        XGE,
        TCE,
        Custom
    }

    public enum Rarity
    {
        none,
        common,
        uncommon,
        rare,
        veryrare,
        legendary,
        unknown
    }
}
