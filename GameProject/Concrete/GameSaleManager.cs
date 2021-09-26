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
        private ICheckService checkService;

        public GameSaleManager(ICheckService checkService)
        {
            this.checkService = checkService;
        }

        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            if (checkService.CheckIfRealPerson(gamer))
            {
                double reservePrice = game.GamePrice - (game.GamePrice * (campaign.CampaingDiscount / 100));
                Console.WriteLine(game.GamePrice + " TL değerindeki " + game.GameName + " oyunu, " + campaign.CampaingName + " ile % " + campaign.CampaingDiscount + " indirim uygulanarak " +
                    reservePrice + " TL fiyatına, "
                    + gamer.FirstName + " " + gamer.LastName + " ismli kullanııya satılmıştır.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" "+"Bu kullanıcı gerçek olmadığından satış engellenmiştir!");
            }

        }
    }
}
