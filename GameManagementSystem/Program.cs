using GameManagementSystem.Adapter;
using GameManagementSystem.Business.Abstract;
using GameManagementSystem.Business.Concrete;
using GameManagementSystem.Entities;
using System;

namespace GameManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerService = new GamerManager(new MernisGamerValidationService());

            gamerService.Add(new Gamer { Id = 1, FirstName = "Hakan", LastName = "Türkoğlu", DateOfBirth = new DateTime(2001, 02, 3), NationalityId = "1000000000", });

        }
    }
}
