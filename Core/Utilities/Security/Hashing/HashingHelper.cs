using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) //Password salt ve hashi oluşturuyor.Out gönderdiğimiz değerleri geri döndürmeye yarıyor.
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) //Cryptography sınfında kullandığımız class
            {
                passwordSalt = hmac.Key; //Her kullanıcı için başka bir key oluşturur.
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //Password ün byte karşılığını aldık.
            }
        } // NOT : Vermiş olduğumuz password değerinin Hash ve Salt yapılarını oluşturduk.

        public static bool VerifyPasswordHash(string password/*sisteme girerken kullanımış olduğu asıl parola*/, byte[] passwordHash, byte[] passwordSalt) //PasswordHashini doğrulama //Buradaki hash veritabanındaki hashimiz
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) //Key doğrulaması yapacağız o yüzden saltı verdik.
            {
                var ComputedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //veritabanında  oluşan hash ile karşılaştıracağız
                for (int i = 0; i < ComputedHash.Length; i++)
                {
                    if (ComputedHash[i] != passwordHash[i])
                    {
                        return false; //Veritabanındaki hash ile girilen hash aynı değil ise false
                    }
                }
                return true; //Veritabanındaki hash ile girilen hash aynı ise true
            }

        }
    }
    //NOT : Burada ilk başta bir hash oluşturuyoruz  daha sonra tekrar giriş yapan kullanıcı için veritabanındaki hash ile giriş yapılan hash aynı olup olmadığı kontrol ediliyor.
}

