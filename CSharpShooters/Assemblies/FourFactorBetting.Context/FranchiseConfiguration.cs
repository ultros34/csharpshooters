using System.ComponentModel.DataAnnotations.Schema;

namespace FourFactorBetting.Context
{
    public class FranchiseConfiguration : EntityConfiguration<Entities.Franchise>
    {
        public FranchiseConfiguration() : base()
        {
            Map(b => b.MapInheritedProperties());

            Property(x => x.FranchiseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Abbreviation).IsRequired().HasMaxLength(3);
            Property(x => x.City).HasMaxLength(100);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.TeamIdentifier).IsRequired().HasMaxLength(100);
            Property(x => x.UrlName).IsRequired().HasMaxLength(100);
        }
    }
}
