using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var kullanicilar = new Dictionary<int, string>();
            //Diğer listelerde olduğu gibi Add() metodu ile ekleme yapıyoruz..
            kullanicilar.Add(0, "Kerem ÖZER");
            kullanicilar.Add(1, "Ali RODOPLU");
            kullanicilar.Add(2, "Okan BİLİR");
            kullanicilar.Add(3, "Sinan ERTAN");
            kullanicilar.Add(4, "Fukan BİÇER");
            kullanicilar.Add(5, "Emirhan DAĞLIOĞLU");

            //Diğer listlerden biraz daha farklı yazdırma işlemi
            //Keyvaluepair dictionarydeki keymiz,
            //ve dictionarydeki value değer tipmiz ne ise onları aynen burada da yazıyoruz

            foreach (KeyValuePair kullanici in kullanicilar)
            {
                Console.WriteLine("ID =>" + kullanici.Key + "\t" + "Ad Soyad =>" + kullanici.Value);
            }
            //Burada dikkat etmemiz gereken nokta
            //Dictionary key uniqtir yani benzersiz
            //Aynı değerler gelirse hata vericektir
            //Peki bunu nasıl önlüyoruz
            string yeniKullanici = "Ekrem AYDEMİR";
            bool varMi = kullanicilar.TryGetValue(0, out yeniKullanici);
            //varsa true yoksa false dondürücek
            if (varMi)
            {
                //Böyle bir key mevcut
                Console.WriteLine("Bu ID de bir kullanici mevcuttur.");
            }
            else
            {
                //Değil ise ekleme işlemini yapalım
                kullanicilar.Add(0, yeniKullanici);
                Console.WriteLine("Ekleme işlemi başarıyla gerçekleşmiştir.");
            }
        }
    }
}
