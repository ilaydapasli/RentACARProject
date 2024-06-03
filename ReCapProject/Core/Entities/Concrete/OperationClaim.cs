using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
//. Entities klasörü kendi içerisinde IEntity implement eden class bir veri tabanı tablosu vardır. 