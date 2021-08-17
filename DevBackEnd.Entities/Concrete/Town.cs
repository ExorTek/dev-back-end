using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Town : IEntity
    {
        public int TownId { get; set; }
        public short CityId { get; set; }
        public string TownName { get; set; }
    }
}