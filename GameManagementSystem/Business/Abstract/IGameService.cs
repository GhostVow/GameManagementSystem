using GameManagementSystem.Entities;

namespace GameManagementSystem.Business.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }


}