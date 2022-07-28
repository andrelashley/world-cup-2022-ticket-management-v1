using System;
using System.Collections.Generic;
using WorldCup2022.TicketManagement.Domain.Common;

namespace WorldCup2022.TicketManagement.Domain.Entities
{
    public class Stage : AuditableEntity
    {
        public Guid StageId { get; set; }
        public string Name { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
