using System;
using DevBackEnd.Core.Entities;

namespace DevBackEnd.Entities.Concrete
{
    public class User : IEntity
    {
        public virtual int UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string NameSurname { get; set; }
        public virtual string Email { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string TelephoneNumber1 { get; set; }
        public virtual string TelephoneNumber2 { get; set; }
    }
}