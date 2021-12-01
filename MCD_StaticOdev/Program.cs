using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşteri adında bir nesne oluşturalım ve oluşturmuş olduğumuz nesnemizin içinde static olarak bir ArrayList oluşturalım.
            //Oluşturduğumuz ArrayList koleksiyonumuzu sanal bir database mantığında kullanacağız.
            //Müşteri sınıfımızın içine ID, Isim, Soyisim, EmailAdres, KullanıcıAdı, Şifre isimleri ile fieldlar oluşturalım.
            //Oluşturmuş olduğumuz bu field listesinden bazılarının kapsülleme filtreleri aşağıdaki gibi olmalıdır.

            //Kullanıcı adı değeri sanal olarak oluşturmuş olduğumuz database imiz içinde aranan
            //eğer kullanıcı adı sanal database içinde bulunursa field içine eklenmek istenen değer eklenemesin.(Kapsülleme)
            //Müşteri ekle adında static metod oluşturalım. Parametre olarak müşteri tipi alsın.
            //İçerisinde Müsteri nesnesinin null olup olmadığını ve müsteri nesnesi içindeki kullanıcı adının dolu olması şartına baksın.
            //Yukarıdaki kriterlerden geçerse müşterimizi sanal olarak oluşturduğumuz database imize eklemeden önce email adresinden bir kontrol sağlasın.
            //Eğer sistemde aynı email adresi ile müşteri değeri var ise eklemesin yok ise sanal database içine ilgili nesneyi eklesin.
        }
    }
}
