using System.ComponentModel.DataAnnotations;

namespace Warranty.Enums
{
    public enum ServiceRequestStatus
    {
        [Display(Name = "Open")]
        Open = 0,

        [Display(Name = "In Progress")]
        inProgress = 1,

        [Display(Name = "Closed")]
        Closed = 2
    }
}
