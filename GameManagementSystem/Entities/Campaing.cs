using GameManagementSystem.Entities.Abstract;

namespace GameManagementSystem.Entities
{
    public class Campaing:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate { get; set; }
    }

}
