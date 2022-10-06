using GameManagementSystem.Entities.Abstract;
using System;

namespace GameManagementSystem.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double UnitPrice { get; set; }
    }

}
