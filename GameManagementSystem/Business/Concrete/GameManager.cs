using GameManagementSystem.Business.Abstract;
using GameManagementSystem.Entities;
using System;

namespace GameManagementSystem.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted!");

        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated!");

        }
    }

}
