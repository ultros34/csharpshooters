using System.Data.Entity.ModelConfiguration;

namespace FourFactorBetting.Context
{
    public class EntityConfiguration<T> : EntityTypeConfiguration<T> where T : Entities.Entity
    {

    }
}
