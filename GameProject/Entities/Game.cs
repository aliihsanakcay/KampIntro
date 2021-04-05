using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Game : IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public decimal GamePrice { get; set; }
    }
}
