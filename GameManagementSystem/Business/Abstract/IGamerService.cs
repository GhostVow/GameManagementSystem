using GameManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementSystem.Business.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }


}