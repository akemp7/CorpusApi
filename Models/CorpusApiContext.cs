using Microsoft.EntityFrameworkCore;

namespace CorpusApi.Models
{
    public class CorpusApiContext: DbContext
    {
        public CorpusApiContext(DbContextOptions<CorpusApiContext> options)
        : base(options)
        {

        }

        public DbSet<Corpus> CorpusApi {get; set; }
       protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Corpus>()
                .HasData(

                    new Corpus {CorpusId = 1, Summary = "This is a summary" },
                    new Corpus {CorpusId = 2, Summary = "This is another summary" }

            );
        }
    }
}
