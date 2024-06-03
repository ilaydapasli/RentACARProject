using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity
        //çıplak class kalmasın. IEntity demek bu bir veritabanıdır demek
        //Ientity brandin referansını tutabiliyor.
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
//Concrete klasörümüzü veri tabanından gelen somut nesnelerin özelliklerini tutmak için oluşturduk