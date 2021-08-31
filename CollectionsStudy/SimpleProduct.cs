using System;

namespace CollectionsStudy
{
    public class SimpleProduct : IEquatable<SimpleProduct>
    {
        public SimpleProduct(int id, decimal price)
        {
            this.Id = id;
            this.Price = price;
        }

        public int Id { get;}

        public decimal Price { get; }

        public bool Equals(SimpleProduct other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return this.Id == other.Id && this.Price == other.Price;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((SimpleProduct) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Price);
        }

        public static bool operator ==(SimpleProduct left, SimpleProduct right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SimpleProduct left, SimpleProduct right)
        {
            return !Equals(left, right);
        }
    }
}