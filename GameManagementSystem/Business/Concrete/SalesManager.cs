using GameManagementSystem.Business.Abstract;
using GameManagementSystem.Entities;
using System;

namespace GameManagementSystem.Business.Concrete
{
    public class SalesManager : ISalesService
    {
        
        public void Sell(Gamer gamer, Game game, Campaing campaing)
        {
            if (campaing != null)
            {
                double discountPrice = (campaing.DiscountRate * game.UnitPrice / 100);
                game.UnitPrice -= discountPrice;
                Console.WriteLine("The game named {0} has been sold successfully. User : {1}", game.Name, gamer.UserName);
            }
            
        }

    }

}
