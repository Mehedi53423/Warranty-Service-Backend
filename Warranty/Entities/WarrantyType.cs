using Warranty.Common;

namespace Warranty.Entities
{
    public class WarrantyType : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurationInMonths { get; set; }
        public string CoverageDetails { get; set; }
    }
}
