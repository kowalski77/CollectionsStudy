using System;

namespace CollectionsStudy
{
    public class ThirdProduct : IComparable<ThirdProduct>
    {
        public ThirdProduct(int id, decimal price)
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

        public int CompareTo(ThirdProduct other)
        {
            if (ReferenceEquals(this, other)) return 0;
            return other is null ? 1 : this.Id.CompareTo(other.Id);
        }
    }
}