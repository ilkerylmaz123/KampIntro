using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            //Do not repat yourself - kendini tekrar etme
            //Dğer tutucu,alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double dolarDun = 7.35;
            double dolarBugun = 8.56;
            bool sistemeGirisYapmisMi = false;

            if (dolarDun>dolarBugun)
            {
                Console.Write("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.Write("Yükseliş butonu");
            }
            else
            {
                Console.Write("Eşit butonu");
            }


            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
           
            


        }
    }
}
