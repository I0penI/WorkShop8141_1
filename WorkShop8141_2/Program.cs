using System.Text;

namespace WorkShop8141_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] basamaklar = new string[]
            // 1234: Bİnler: 1, Yüzler: 2, Onlar: 3, Birler: 4
            {
                "Binler", "Yüzler", "Onlar", "Birler"
            };
            Console.Write($"{basamaklar.Length} Haneli Sayıyı Giriniz: ");
            string giris = Console.ReadLine(); //1234
            if (giris.Length != basamaklar.Length)
            {
                Console.WriteLine("Lütfen hane sayısını doğru girin!");
            }
            else
            {
                bool bulundu= false;
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
                        Console.WriteLine("Lütfen sayısal veri giriniz!");
                        break;
                    }
                }
                if (bulundu == true)
                {
                    string sonuc = "";
                    for (int i = 0; i < giris.Length; i++)
                    {
                        sonuc += basamaklar[i] + ": " + giris[i] + ", ";
                    }

                    Console.WriteLine(sonuc.TrimEnd(',', ' '));
                }
            }
        }



    }
}