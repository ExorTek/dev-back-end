﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
   public class District:IEntity
    {
        public int DistrictId { get; set; }
        public int TownId { get; set; }
        public string DistrictName { get; set; }

    }
}