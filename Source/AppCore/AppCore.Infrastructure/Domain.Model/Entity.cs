using System;

namespace AppCore.Infrastructure.Domain.Model
{
    public abstract class Entity
    {
        public virtual Guid Id { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            Entity item = (Entity)obj;
            return item.Id == this.Id;
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
            {
                return (Object.Equals(right, null)) ? true : false;
            }
            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}