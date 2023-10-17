using System.ComponentModel.DataAnnotations;

namespace PartyLoot.Models
{
    public class Item
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Source Source { get; set; }
        [Required]
        public Rarity Rarity { get; set; }
        [Required]
        [MaxLength(20)]
        public string Type { get; set; }
        [MaxLength(20)]
        public string Attunement { get; set; }
        [Required]
        [MaxLength(200)]
        public string Properties { get; set; }
        [Required]
        public decimal WeightInOz { get; set; }
        [Required]
        public decimal ValueInGold { get; set; }
        [MaxLength(200)]
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
