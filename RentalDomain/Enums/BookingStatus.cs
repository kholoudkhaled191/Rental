using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Domain.Enums
{
    public enum BookingStatus
    {
        Pending = 1,
        Confirmed = 2,
        PickedUp = 3,
        Returned = 4,
        Completed = 5,
        Cancelled = 6,
        OverDue = 7,
    }
}
