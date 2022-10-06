using GameManagementSystem.Entities;

namespace GameManagementSystem.Business.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        Campaing GetById(int campaignId);
        void Update(Campaing campaing);
    }


}