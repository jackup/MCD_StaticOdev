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

            Musteri m1 = new Musteri();
            m1.Id = 01;
            m1.Isim = "yakup";
            m1.Soyisim = "kömük";
            m1.KullaniciAdi = "jackup";
            m1.Sifre = "sanane";
            m1.EmailAdres = "yk.58@hotmail.com";

            Musteri m2 = new Musteri();
            m2.Id = 02;
            m2.Isim = "yusuf";
            m2.Soyisim = "kömük";
            m2.KullaniciAdi = "joseph";
            m2.Sifre = "asfdsadg";
            m2.EmailAdres = "yk.58@hotmail.com";


            Musteri.MusteriEkle(m1);
            Musteri.MusteriEkle(m2);


            foreach (Musteri item in Musteri.A1)
            {
                Console.WriteLine(item.EmailAdres);
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Soyisim);
                Console.WriteLine(item.KullaniciAdi);
                Console.WriteLine(item.Sifre);
                Console.WriteLine("*******************");
            }
        }
    }
}
