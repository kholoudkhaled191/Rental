using Rental.Domain.Common;
using Rental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Domain.Entities
{
    public class ConditionReport:BaseEntity
    {
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

        public ConditionReportType Type { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string ImagesJson { get; set; }

    }
}
