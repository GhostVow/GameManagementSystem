using GameManagementSystem.Business.Abstract;
using GameManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementSystem.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("User added!");
            }
            else
            {
                throw new Exception("Not a valid person!!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("User deleted!");

        }

        public void Update(Gamer gamer)
        {
            if (true)
            {
                Console.WriteLine("User added!");
            }
            else
            {
                throw new Exception("Not a valid person!!");
            }

        }
    }

}
