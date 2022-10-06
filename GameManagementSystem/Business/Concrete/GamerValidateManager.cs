using GameManagementSystem.Business.Abstract;
using GameManagementSystem.Entities;

namespace GameManagementSystem.Business.Concrete
{
    public class GamerValidateManager : IGamerValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }

}
