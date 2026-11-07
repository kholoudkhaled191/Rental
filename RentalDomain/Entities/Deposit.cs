using Rental.Domain.Common;
using Rental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Domain.Entities
{
    public class Deposit:BaseEntity
    {
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

        public decimal Amount { get; set; }

        public DepositStatus status { get; set; } = DepositStatus.Held;

        public decimal? DeductionAmount { get; set; }

        public string? DeductionReason { get; set; }


    }
}
