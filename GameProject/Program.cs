using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Adapters;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // OYUNCU (Gamer) İŞLEMLERİ
            Console.WriteLine("*******  OYUNCU İŞLEMLERİ *******");
            Console.WriteLine("");
            //**********1.Ekleme yöntemi
            Gamer gamer = new Gamer()
            {
                GamerId = 1,
                FirstName = "Aleyna Yağmur",
                LastName = "TÜMTÜRK",
                DateOfBirth = new DateTime(1999, 05, 14),
                NationalityId = "12345678912"

            };
            Gamer gamer2 = new Gamer()
            {
                GamerId = 2,
                FirstName = "Kağan",
                LastName = "ÖZTÜRK",
                DateOfBirth = new DateTime(1998, 06, 26),
                NationalityId = "12345678910"

            };
            BaseGamerManager  baseGamerManager = new GamerManager(new MernisServiceAdapters());
            GamerManager gamerManager = new GamerManager();

                //1.OYUNCU EKLEME-SİLME-GÜNCELLEME

            baseGamerManager.Add(gamer);
            baseGamerManager.Update(gamer);
            baseGamerManager.Remove(gamer);

                //2.OYUNCU EKLEME-SİLME-GÜNCELLEME

            baseGamerManager.Add(gamer2);
            baseGamerManager.Update(gamer2);
            baseGamerManager.Remove(gamer2);


            //********2.Ekleme Yöntemi

            //BaseGamerManager  baseGamerManager = new GamerManager(new MernisServiceAdapters());
            //baseGamerManager.Add(new Gamer { DateOfBirth = new DateTime(1999, 05, 14), FirstName = "Aleyna Yağmur", LastName = "Tümtürk", NationalityId = "10510238336" });

            // OYUN(GAME) İŞLEMLERİ
            Console.WriteLine("");
            Console.WriteLine("*******  OYUN İŞLEMLERİ *******");
            Console.WriteLine("");
            Game game1 = new Game()
            {
                GameId=1,
                GameName="Süper Mario",
                GameDescription="Macera",
                GamePrice=50
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Remove(game1);

            //KAMPANYA (CAMPAIGN) İŞLEMLERİ
            Console.WriteLine("*******  KAMPANYA İŞLEMLERİ *******");
            Console.WriteLine("");
            Campaign bahar = new Campaign()
            {
                CampaingName="BAHAR İNDİRİMİ",
                CampaingDiscount=15
            };

            Campaign yeniYıl = new Campaign()
            {
                CampaingName="YENİ YIL İNDİRMİ",
                CampaingDiscount=10
            };
            CampaignManager campaignManager = new CampaignManager();
            // BAHAR KAMPANYASI İŞLEMLERİ
            campaignManager.Add(bahar);
            campaignManager.Remove(bahar);
            campaignManager.Update(bahar);
            // YENİ YIL KAMPANYASI İŞLEMLERİ
            Console.WriteLine("");
            campaignManager.Add(yeniYıl);
            campaignManager.Remove(yeniYıl);
            campaignManager.Update(yeniYıl);

            //SATIŞ İŞLEMLERİ
            Console.WriteLine("*******  SATIŞ İŞLEMLERİ *******");
            Console.WriteLine("");

           
            GameSaleManager gameSaleManager = new GameSaleManager(new MernisServiceAdapters());
            gameSaleManager.Sale(gamer2,game1,bahar);
            gameSaleManager.Sale(gamer, game1, yeniYıl);
            Console.ReadLine();
        }

    }
}
