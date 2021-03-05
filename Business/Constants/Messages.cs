using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {   // IMessages ile süsleyebilirsin - Çok dil destekli hale getirebilirsin.
        // ismi büyük harfle yazdık field olmasına ragmen cünkü public
        // Messagelarıda ayırabilirsin sınıflandırabilirsin
        public static string CarAdded = "Car added";
        public static string BrandAdded = "Brand added";
        public static string RentAdded = "Car rented";
        public static string CarNameInvalid = "Car name invalid";
        public static string CarsListed = "Cars listed";
        public static string MaintenanceTime = "System maintenance time";
        public static string NoInGarage = "Car is not in garage";
        public static string CarImageAdded = "Car image added.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfullLogin = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
    }
}
