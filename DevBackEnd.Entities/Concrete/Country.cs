﻿using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class Country : IEntity
    {
        public virtual byte CountryId { get; set; }
        public virtual string CountryName { get; set; }
    }
}