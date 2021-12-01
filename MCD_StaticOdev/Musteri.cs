using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_StaticOdev
{
    class Musteri
    {
        public static ArrayList A1;


        private int id;
        private string isim;
        private string soyisim;
        private string emailAdres;
        private string kullaniciAdi;
        private string sifre;

        public int Id { get => id; set => id = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string EmailAdres { get => emailAdres; set => emailAdres = value; }
        public string KullaniciAdi {
            get => kullaniciAdi; set => kullaniciAdi = value;
            //get
            //{
            //    return this.kullaniciAdi;
            //}
            //set
            //{
            //    this.kullaniciAdi = value;
            //    if (A1.Contains(value))
            //    {
            //    }
            //    else
            //    {
            //        this.kullaniciAdi = value;
            //    }
            //}
        }
        public string Sifre { get => sifre; set => sifre = value; }


        public static void MusteriEkle(Musteri musteri)
        {
            if (musteri == null || musteri.KullaniciAdi == string.Empty)
            {
                Console.WriteLine("Hata");
            }
            else
            {
                bool check = musteriEmailAdresKontrol(musteri.emailAdres);
                if (check)
                {
                    Console.WriteLine("Sistemde bu mail adresi zaten var.");
                }
                else
                {
                    A1.Add(musteri);
                    Console.WriteLine("Müşteri Database'e eklendi. ");
                }

            }
            
        }

        static bool musteriEmailAdresKontrol(string emailAdres)
        {
            bool Kontrol = false;

            for (int i = 0; i < A1.Count; i++)
            {
                Musteri Temp = (Musteri)A1[i];
                if (Temp.emailAdres == emailAdres)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }

        public Musteri()
        {
            A1 = new ArrayList();
        }
    }
}

