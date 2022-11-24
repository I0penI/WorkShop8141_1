namespace TCKimlik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T.C kimlik numaranızı giriniz: ");
            string kimlikNo = Console.ReadLine();
            bool sonuc = Dogrula1(kimlikNo);
            if (sonuc)
                Console.WriteLine("Kimlik No Doğrudur");
            else
                Console.WriteLine("Kimlilk No Yanlış!");

        }
        static bool Dogrula1(string kimlik)
        {
            bool sonuc = false;
            double[] sayilar;
            double toplam1 = 0;
            double toplam2 = 0;
            if (kimlik.Length == 11)
            {
                if (kimlik[0] != '0')
                {
                    
                    if (SayisalMi(kimlik))
                    {
                        sayilar = Donustur(kimlik);
                        for (int i = 0; i <= 8; i += 2)
                        {
                            toplam1 += sayilar[i];
                        }
                        for (int i = 1; i <= 7; i += 2)
                        {
                            toplam2 += sayilar[i];
                        }
                        if ((toplam1 * 7 - toplam2) % 10 == sayilar[9])
                        {
                            toplam1 = 0;
                            for (int i = 0; i <= 9; i++)
                            {
                                toplam1 = toplam1 + sayilar[i];
                            }
                            if (toplam1 % 10 == sayilar[10])
                            {
                                sonuc = true;
                            }
                        }
                    }
                }
            }
            return sonuc;
        }
        static double[] Donustur(string giris)
        {
            double[] sayilar = new double[giris.Length];
            int i = 0;
            foreach (char c in giris)
            {
                sayilar[i] = Convert.ToDouble(c.ToString());
                i++;
            }
            return sayilar;
        }
        static bool SayisalMi(string giris)
        {
            bool bulundu = false;
            for (int i = 0; i < giris.Length; i++)
            {
                bulundu = false;
                for (char c = '0'; c <= '9'; c++)
                {
                    if (giris[i] == c)
                    {
                        bulundu = true;
                        break;
                    }
                }
                if (bulundu == false)
                {
                    break;
                }

            }
            return bulundu;
        }


    }
}