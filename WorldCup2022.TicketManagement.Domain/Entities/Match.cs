using WorldCup2022.TicketManagement.Domain.Common;

namespace WorldCup2022.TicketManagement.Domain.Entities
{
    public class Match : AuditableEntity
    {
        public string MatchId { get; set; }
        public string Description { get; set; }
        public Stage Stage { get; set; }
    }
}
