using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IPersonCheckService _personCheckService;
        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_personCheckService.CheckPerson(gamer))
            {
                Console.WriteLine("{0} eklendi.", gamer.FirstName);
            }
            else
            {
                Console.WriteLine("{0} NOT A VALID PERSON!", gamer.FirstName);
            }
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
