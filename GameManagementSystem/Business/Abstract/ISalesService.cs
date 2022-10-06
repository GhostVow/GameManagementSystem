using GameManagementSystem.Entities;

namespace GameManagementSystem.Business.Abstract
{
    public interface ISalesService
    {
        void Sell(Gamer gamer, Game game, Campaing campaing);
       
    }


}