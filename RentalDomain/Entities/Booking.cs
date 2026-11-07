using Rental.Domain.Common;
using Rental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Domain.Entities
{
    public class Booking:BaseEntity
    {
        public string UserId { get; set; } = string.Empty;

        public Guid ProductId { get; set; }

        public Product product { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }

        public BookingStatus status { get; set; } = BookingStatus.Pending;

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Deposit Deposit { get; set; }

        public ICollection<ConditionReport> ConditionReports { get; set; } =new List<ConditionReport>();

    }
}
