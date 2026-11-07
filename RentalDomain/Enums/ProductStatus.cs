using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Domain.Enums
{
    public enum ProductStatus
    {
        Available=1,
        Rented = 2,
        Maintenance = 4,
        Discontinued = 3
    }
}
