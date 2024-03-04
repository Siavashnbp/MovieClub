using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Entities.RentInformations
{
    public class RentInformation
    {
        public decimal PricePerDay { get; set; }
        public decimal PenaltyPerDay { get; set; }
        public TimeSpan RentDuration { get; set; }

    }
    public enum RentStatus
    {
        InRent,
        Returned,
        Delayed
    }
}
