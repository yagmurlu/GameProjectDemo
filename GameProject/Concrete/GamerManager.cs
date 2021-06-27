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
    public class GamerManager:BaseGamerManager
    {
     
        //private MernisServiceAdapters mernisServiceAdapters;
        private ICheckService _checkService;
        public GamerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public GamerManager()
        {
        }
      
        public override void Add(Gamer gamer)
        {
            if (_checkService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Bu kullanıcı geçerli değil!");
            }
        }


        //public void Remove(Gamer gamer)
        //{
        //    if (_checkService.CheckIfRealPerson(gamer))
        //    {
        //        Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "adlı oyuncu silindi!");
        //    }
        //}

        //public void Update(Gamer gamer)
        //{
        //    if (_checkService.CheckIfRealPerson(gamer))
        //    {
        //        Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "adlı oyuncu güncellendi!");
        //    }
        //}
    }
}
