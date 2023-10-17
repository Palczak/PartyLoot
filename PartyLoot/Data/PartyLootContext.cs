using Microsoft.EntityFrameworkCore;
using PartyLoot.Models;

namespace PartyLoot.Data
{
    public class PartyLootContext : DbContext
    {
        public PartyLootContext (DbContextOptions<PartyLootContext> options)
            : base(options)
        {
        }

        public DbSet<PartyLoot.Models.Party> Party { get; set; } = default!;

        public DbSet<PartyLoot.Models.Item>? Item { get; set; }
    }
}
