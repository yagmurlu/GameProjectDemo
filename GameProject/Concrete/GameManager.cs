using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager:IGameService
    {
        public virtual void Add(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun, " + game.GamePrice + " fiyatı ile eklendi. \n" +
                game.GameDescription);
        }
        public virtual void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun" + " silindi! ");

        }

        public virtual void Update(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun" + " güncellendi! ");
        }
    }
}
