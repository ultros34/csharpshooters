using FourFactorBetting.Enumerators;

namespace FourFactorBetting.Entities
{
    public class Franchise : Entity
    {
        public virtual int FranchiseId { get; set; }
        public virtual string Name { get; set; }
        public virtual string City { get; set; }
        public virtual string Abbreviation { get; set; }
        public virtual string UrlName { get; set; }
        public virtual Conference Conference { get; set; }
        public virtual Division Division { get; set; }
        public virtual string TeamIdentifier { get; set; }
    }
}
