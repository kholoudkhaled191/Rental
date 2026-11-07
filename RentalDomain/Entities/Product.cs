using Rental.Domain.Common;
using Rental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Domain.Entities
{
     public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Describtion { get; set; } = string.Empty;

        public decimal DailyRate { get; set; }

        public decimal DepositAmount { get; set; }

        public ProductStatus Status { get; set; } = ProductStatus.Available;

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Guid  CategoryId { get; set; }


        public Category Category { get; set; }


        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();




    }
}
