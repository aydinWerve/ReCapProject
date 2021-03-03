using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string PriceFilter = "Günlük Fiyatı 0'dan büyük olmalıdır !!";
        public static string BrandNameFilter = "Araba markası 2 karakterden fazla olmalıdır";
        public static string CarsListed = "Arabalar listelendi";
        public static string CannotBeRented = "Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.";
        public static string NoCar = "Malesef yoğunluk sebebiyle elimizde araç bulunmamaktadır";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
