﻿using DevBackEnd.Core.DataAccess;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Abstract
{
    public interface IPaymentDal : IEntityRepository<Payment>
    {
    }
}