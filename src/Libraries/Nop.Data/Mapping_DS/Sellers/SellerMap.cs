using Nop.Core.Domain.Customers;
using Nop.Data.Mapping;
using DS.Core.Domain.Sellers;

namespace DS.Data.Mapping.Sellers
{
    public partial class SellerMap : NopEntityTypeConfiguration<Seller>
    {
        public SellerMap()
        {
            this.ToTable("Seller");
            this.HasKey(c => c.Id);
        }
    }
}