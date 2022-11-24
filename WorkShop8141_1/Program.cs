namespace WorkShop8141_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  * dama
            //      *
            //      **
            //      ***
            //      ****
            //      *****
            //      */
            //     for (int i = 1; i <= 5; i++)
            //     {
            //         for (int j = 1; j <= i; j++)
            //         {
            //             Console.Write("*");
            //         }
            //         Console.WriteLine();

            //     }

            //     /*
            //      * * * *
            //       * * * *
            //      * * * *
            //       * * * *
            //      * * * *
            //       * * * *
            //      * * * *
            //       * * * *
            //      */
            //     string kare = "";
            //     for (int i = 1; i <= 8; i++)
            //     {
            //         if (i % 2 == 0)
            //             kare += " ";


            //         for (int j = 1; j <= 8; j++)
            //         {
            //             if (j % 2 != 0)
            //                 kare += "*";
            //             else
            //                 kare += " ";

            //         }
            //         kare += "\n";
            //     }
            //     Console.WriteLine(kare);
            //     */
            #endregion

            Console.Write("Ad Giriniz (çıkış için ç): ");
            string ad = Console.ReadLine();
            string sonuc;
            while (ad.ToLower() != "ç")
            {
                sonuc = Donustur(ad);
                Console.WriteLine(sonuc);
                Console.Write("Ad Giriniz (çıkış için ç): ");
                ad = Console.ReadLine();
            }

        }

        static string Donustur(string ad)
        {
            string sonuc = "";
            string[] kelimeler = ad.Split(' ');
            foreach (string kelime in kelimeler)
            {
                sonuc += IlkHarfBuyult(kelime) + " ";
            }
            return sonuc.TrimEnd();
        }

        static string IlkHarfBuyult(string input)
        {
            string sonuc;
            sonuc = input.Substring(0, 1).ToUpper();
            sonuc += input.Substring(1).ToLower();
            return sonuc;
        }


    }
}