namespace TC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kİmlik Numarası Gir: ");
            string giris = Console.ReadLine(); //12345678901
            bool sonuc = Dogrula(giris);
            if (sonuc)
                Console.WriteLine("Giriş Başarılı");
            else
                Console.WriteLine("Hatalı Giriş!");
        }

        static bool Dogrula(string kimlikNo)
        {
            double tumHaneIslem;
            double ciftHaneIslem;
            double tekHaneIslem;
            double[] sayilar;
            if (kimlikNo.Length != 11)
                return false;
            if (!SayisalMi(kimlikNo))
                return false;
            sayilar = SayisalaDonustur(kimlikNo);          
            if (sayilar[0] == 0)
                return false;

            tekHaneIslem = (sayilar[0] + sayilar[2] + sayilar[4] + sayilar[6] + sayilar[8]);
            ciftHaneIslem = sayilar[1] + sayilar[3] + sayilar[5] + sayilar[7];

            if ((tekHaneIslem * 7 - ciftHaneIslem) % 10 != sayilar[9])
                return false;
            tumHaneIslem = tekHaneIslem + ciftHaneIslem + sayilar[9];
            if (tumHaneIslem % 10 != sayilar[10])
                return false;
            return true;
        }

        static double[] SayisalaDonustur(string deger)
        {
            double[] sayilar = new double[deger.Length];
            int i = 0;
            while (i < sayilar.Length)
            {
                sayilar[i] = Convert.ToDouble(deger[i].ToString());
                i++;
            }
            return sayilar;
        }
        static bool SayisalMi(string deger)
        {
            bool bulundu = true;
            for (int degerIndex = 0; degerIndex < deger.Length && bulundu; degerIndex++)
            {
                bulundu = false;
                for (char sayisalKarakter = '0'; sayisalKarakter <= '9' && !bulundu; sayisalKarakter++)
                {
                    if (deger[degerIndex] == sayisalKarakter) 
                    {
                        bulundu = true;                                     
                    }
                }
            }
            return bulundu;
        }
        
    }
}