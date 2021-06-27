using GameProject.Abstract;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameSaleManager :ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            double reservePrice = game.GamePrice-(game.GamePrice*(campaign.CampaingDiscount/100));
            Console.WriteLine(game.GamePrice+" TL değerindeki "+game.GameName+" oyunu, "+campaign.CampaingName+" ile % "+campaign.CampaingDiscount+" indirim uygulanarak "+
                reservePrice+" TL fiyatına, "
                +gamer.FirstName+" "+gamer.LastName+" ismli kullanııya satılmıştır.");

        }
    }
}
