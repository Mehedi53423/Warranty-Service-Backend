using Warranty.Common;
using Warranty.Enums;

namespace Warranty.Entities
{
    public class ServiceRequest : BaseEntity
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public DateTime RequestDate { get; set; }
        public string IssueDescription { get; set; }
        public ServiceRequestStatus Status { get; set; }
    }
}
