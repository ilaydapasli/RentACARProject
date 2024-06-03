using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
//Bu katmanımızın içindeki klasörlerde ise alt yapısı hazır olan bütün servislerin yönetimleri yazıldı.
//Sürekli değişebilen iş kodlarımızı altyapıyı değiştirmeden ekleyebildiğimiz katmandır diyebiliriz. Sürekliliğin
//korunduğu bu projemizde birçok değişikliğin sadece burada yapılıyor olması yönetimi, sürekli gelişimi kolaylaştırmaktadır.