using System;
using WorldCup2022.TicketManagement.Domain.Common;

namespace WorldCup2022.TicketManagement.Domain.Entities
{
    public class Venue : AuditableEntity
    {
        public Guid VenueId { get; set; }
        public string Name { get; set; }
    }
}
