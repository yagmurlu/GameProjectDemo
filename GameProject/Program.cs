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
            //Gamer gamer = new Gamer()
            //{
            //    GamerId=1,
            //    FirstName = "Aleyna Yağmur",
            //    LastName = "TÜMTÜRK",
            //    DateOfBirth = new DateTime(1998, 05, 14),
            //    NationalityId = "10510238336"

            //};
            //GamerManager gamerManager = new GamerManager();
            //gamerManager.Add(gamer);

            BaseGamerManager  baseGamerManager = new GamerManager(new MernisServiceAdapters());
            baseGamerManager.Add(new Gamer { DateOfBirth = new DateTime(1999, 05, 14), FirstName = "Aleyna Yağmur", LastName = "Tümtürk", NationalityId = "10510238336" });
            Console.ReadLine();
        }

    }
}
