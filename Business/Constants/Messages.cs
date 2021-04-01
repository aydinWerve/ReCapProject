using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Başarılı bir şekilde eklenmiştir!";
        public static string NotAdded = "Malesef eklenemez!";

        public static string Deleted = "Başarılı bir şekilde silinmiştir!";
        public static string NotDeleted = "Malesef silinemez!";

        public static string Updated = "Başarılı bir şekilde güncellenmiştir!";
        public static string NotUpdated = "Malesef güncellenemez!";

        public static string Listed = "Başarılı bir şekilde listelenmiştir!";
        public static string NotListed = "Malesef listelenemez!";


        public static string ReturnDateOfRentalError = "Araç teslim edilmediği için gerçekleştirmeye çalıştığınız işlem yapılamaz!";
        public static string CarCheckImageLimited = "Bir arabanın en fazla 5 resmi olabilir!";


        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
