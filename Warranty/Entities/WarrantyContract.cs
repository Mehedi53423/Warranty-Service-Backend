using Warranty.Common;

namespace Warranty.Entities
{
    public class WarrantyContract : BaseEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int WarrantyTypeId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
    }
}
