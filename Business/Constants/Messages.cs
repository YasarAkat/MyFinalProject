using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //PRODUCT MESSAGES
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public  static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";

        //CATEGORY MESSAGES
        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string CategoryNameInvalid = "Kategori ismi geçersiz";
        public static string CategoriesListed = "Kategori listelendi";

        //ORDER MESSAGES
        public static string OrderAdded = "Sipariş eklendi";
        public static string OrderDeleted = "Sipariş silindi";
        public static string OrderUpdated = "Sipariş güncellendi";
        public static string OrderNameInvalid = "Sipariş ismi geçersiz";
        public static string OrdersListed = "Sipariş listelendi";
        public  static string ProductCountOfCategoryError = "Bir kategori en fazla 10 ürün içerebilir";
        public  static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün mevcut";
        public  static string CategoryLimitExceded="Kategori limiti aşıldığı için ürün eklenemiyor";
    }
}
