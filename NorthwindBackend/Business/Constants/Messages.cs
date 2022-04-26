using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductAddedInvalid = "Ürün Eklenemedi";
        public static string ProductDeletedInvalid = "Ürün Silinemedi";
        public static string ProductUpdatedInvalid = "Ürün Güncellenemedi";
        public static string ProductListedInvalid = "Ürünler Listelenemedi";

        public static string ProductCountOfCategoryError = "En fazla 10 ürün olabilir.";

        public static string ProductNameAlreadyExists = "Bu ürün daha önceden eklenmiştir";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
