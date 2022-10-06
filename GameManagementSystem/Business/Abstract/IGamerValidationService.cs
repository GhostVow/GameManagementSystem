using GameManagementSystem.Entities;

namespace GameManagementSystem.Business.Abstract
{
    public interface IGamerValidationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }


}