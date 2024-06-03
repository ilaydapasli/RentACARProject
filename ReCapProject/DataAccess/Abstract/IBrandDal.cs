using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>
    {
    }
}
//Abstract interfaceleri barındıran ve Concrete class’ları barındıran klasörlerimiz bulunmaktadır. Crud operasyonlarını core katmanından miras alarak gerçekleştiririz.
//Gelebilecek iş kodları için alt yapıyı burada hazırlarız. Objelerin veri transferleri için kullanacağı database’ler ve varlıkların bağlantıları bu katmanda yapılandırdık.