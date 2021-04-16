using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Arac eklendi";

        public static string InvalidCarAdded = "Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır";

        public static string CarDeleted = "Arac silindi";

        public static string CarUpdated = "Arac guncellendi";

        public static string CarListed = "Araclar listelendi";

        public static string CarListedByBrandId = "Araclar markalarina gore listelendi";

        public static string CarListedByColorId = "Araclar renklerine gore listelendi";

        public static string InvalidCarListed = "Server bakimda";

        public static string BrandAdded = "Marka eklendi";

        public static string BrandDeleted = "Marka silindi";

        public static string BrandUpdated = "Marka guncellendi";

        public static string BrandListed = "Marka listendi";

        public static string ColorAdded = "Renk eklendi";

        public static string ColorDeleted = "Renk silindi";

        public static string ColorUpdated = "Renk guncellendi";

        public static string ColorListed = "Renk listelendi";

        public static string CustomerAdded = "Musteri eklendi";

        public static string CustomerDeleted = "Musteri silindi";

        public static string CustomerUpdated = "Musteri guncellendi";

        public static string CustomerListed = "Musteri listelendi";

        public static string RentalAdded= "Kiralama eklendi";

        public static string InvalidRentalAdded = "Arac yeniden kiralanmasi icin teslim edilmelidir";

        public static string RentalDelete = "Kiralama silindi";

        public static string RentalUpdated = "Kiralam guncellendi";

        public static string RentalListed = "Kiralama listelendi";

        public static string RentalUndeliveredCar = "Kiralanmis arac teslim edilmemiş";

        public static string UserAdded = "Kullanci eklendi";

        public static string UserDelete = "Kulanici silindi";

        public static string UserUpdated = "Kullanci guncellendi";

        public static string UserListed = "Kullanici listelendi";

        public static string CarImageAdded = "Arac fotosu eklendi";
        
        public static string CarImageDeleted = "Arac fotosu silindi";
        
        public static string CarImageUpdated = "Arac fotosu guncellendi";

        public static string CarImageListed = "Arac fotosu listelendi";

        public static string CarImageLimit = "Aracin maks 5 fotosu ola bilir";

        public static string ImageGetByCarId = "Aracin id gore fotosu listelendi";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanici kayit oldu";

        public static string UserNotFound = "Kullanici bulunamadi";

        public static string PasswordError = "Sifre hatali";

        public static string SuccessfulLogin = "Basarili giris";

        public static string UserAlreadyExists = "Kullanici mevcut";

        public static string AccessTokenCreated = " Tokeni olusturuldu";
    }
}
