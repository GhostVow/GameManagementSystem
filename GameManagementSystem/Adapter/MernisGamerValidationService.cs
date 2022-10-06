using GameManagementSystem.Business.Abstract;
using GameManagementSystem.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementSystem.Adapter
{
    public class MernisGamerValidationService : IGamerValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var result = client.TCKimlikNoDogrulaAsync(long.Parse(gamer.NationalityId),gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.DateOfBirth.Year)
                .GetAwaiter().GetResult().Body.TCKimlikNoDogrulaResult;

            return result;
        }
    }
}
