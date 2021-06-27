using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Adapters;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                NationalityId = "10510238336"

            };
            Gamer gamer2 = new Gamer()
            {
                GamerId = 2,
                FirstName = "Kağan",
                LastName = "ÖZTÜRK",
                DateOfBirth = new DateTime(1999, 06, 26),
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
                GamePrice=10
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Remove(game1);
            
            
            
            Console.ReadLine();
        }

    }
}
