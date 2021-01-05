using Abp.Domain.Entities;
using System;

namespace muoi.Core
{
    public class Tableone:Entity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreateT { get; set; }
       public Tableone()
        {
            CreateT = DateTime.Now;
        }

    }
}