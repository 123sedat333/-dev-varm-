using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_varmış
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cinsiyetinizi girin (Erkek/Kadın):");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Yaşınızı girin:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maaşınızı girin:");
            double maas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hangi Günü girin");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (cinsiyet)
            {

                case "erkek":
                    if (yas >= 60)
                    {
                        Console.WriteLine("Maaşınızın 10 katı değerinde ikramiye" + (maas * 10));

                    }
                    else if (maas < 60 && gun > 6000)
                    {
                        Console.WriteLine("Herhangi bir ikramiye alamasınız....");
                    }
                    else
                    {
                        Console.WriteLine("hatalı yaş üstü gün bilgisi giriniz");
                    }
                    break;

                case "kadın":
                    if (yas >= 58)
                    {
                        Console.WriteLine("Maaşınızın 10 katı değerinde ikramiye" + (maas * 10));
                    }
                    else if (maas < 58 && gun > 4500)
                    {
                        Console.WriteLine("Herhangi bir ikramiye alamasınız....");
                    }
                    else
                    {
                        Console.WriteLine("hatalı yaş üstü gün bilgisi giriniz");
                    }
                    break;



            }



















































            Console.ReadLine();


        }
    }
}
