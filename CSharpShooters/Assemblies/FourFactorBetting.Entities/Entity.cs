using System;

namespace FourFactorBetting.Entities
{
    public class Entity
    {
        public virtual byte[] Version { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string LastModifiedBy { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
        public virtual bool Active { get; set; }
    }
}
