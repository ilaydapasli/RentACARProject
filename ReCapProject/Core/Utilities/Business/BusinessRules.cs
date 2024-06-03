using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }

        public static object Run(IResult result, object chechIfImageIsValid)
        {
            throw new NotImplementedException();
        }
    }
}
//Utilities içerisinde iş metodu kurallarının yönetimini kolaylaştırdık, belge ekleme işlemleri,
//aspectlerin araya girebilmesi için altyapı hazırladık, result yapısı kurularak hata yönetimini yapılandırdık,
//jwt ve hashing teknikleri ile de güvenlik yapılandırıldı.