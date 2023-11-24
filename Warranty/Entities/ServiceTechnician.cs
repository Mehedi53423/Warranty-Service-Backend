using Warranty.Common;

namespace Warranty.Entities
{
    public class ServiceTechnician : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
    }
}
