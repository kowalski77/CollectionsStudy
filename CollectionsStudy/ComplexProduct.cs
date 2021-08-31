using System;

namespace CollectionsStudy
{
    public class ComplexProduct : IEquatable<ComplexProduct>, IComparable<ComplexProduct>
    {
        public ComplexProduct(int id, decimal price)
        {
            this.Id = id;
            this.Price = price;
        }

        public int Id { get; }

        public decimal Price { get; }

        public override string ToString()
        {
            return $"Id: {this.Id} - Price: {this.Price}";
        }

        public bool Equals(ComplexProduct other)
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
            return this.Equals((ComplexProduct) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Price);
        }

        public static bool operator ==(ComplexProduct left, ComplexProduct right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ComplexProduct left, ComplexProduct right)
        {
            return !Equals(left, right);
        }

        public int CompareTo(ComplexProduct other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;
            var idComparison = this.Id.CompareTo(other.Id);
            if (idComparison != 0) return idComparison;
            return this.Price.CompareTo(other.Price);
        }
    }
}