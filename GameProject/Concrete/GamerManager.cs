using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        public GamerManager()
        {

        }
        private ICheckService _checkService;
        public GamerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }
        public void Add(Gamer gamer)
        {
            if (true)
            {

            }
        }


        public void Remove(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
