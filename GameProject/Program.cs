using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer = new Gamer
            {
                GamerId=1, FirstName="Ali İhsan", LastName="Akçay", NationalityId="12345", DateOfBirth= new DateTime(1993, 9, 1)
            };


            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);
            


            Console.ReadLine();
        }
    }
}
