using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("% "+campaign.CampaingDiscount+" "+campaign.CampaingName+" kampanyası eklendi!");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " kampanyası kaldırıldı!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("% "+campaign.CampaingDiscount+" "+ campaign.CampaingName + " kampanyası güncellendi!");
        }
    }
}
