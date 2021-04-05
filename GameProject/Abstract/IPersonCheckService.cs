using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IPersonCheckService
    {
        bool CheckPerson(Gamer gamer);
    }
}
