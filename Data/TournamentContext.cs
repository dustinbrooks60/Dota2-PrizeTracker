using Microsoft.EntityFrameworkCore;

namespace PrizeTracker.Models
{
    public class TournamentContext : DbContext
    {
        public TournamentContext (DbContextOptions<TournamentContext> options)
            : base(options)
        {
        }

        public DbSet<PrizeTracker.Models.Tournament> Tournament { get; set; }
    }
}