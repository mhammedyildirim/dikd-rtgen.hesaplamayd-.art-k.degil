using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdörtgen.hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            int yas;
            double boy;
            
            Console.Write("Lutfen isminizi giriniz:");
             isim = Console.ReadLine();
            //isimi aldık kullanıcıdan
            Console.Write("Lutfen yasinizi giriniz:");
            yas = Convert.ToInt32(Console.ReadLine());
            //yasi aldik simdi de
            Console.Write("Lutfen boyunuzu cm cinsinden giriniz:");
            boy = Convert.ToInt32(Console.ReadLine());
            //simdi de boyu aldık

            Console.WriteLine("Merhaba {0} bey {1} yasindasiniz {2} boyundasiniz", isim, yas, boy);

            Console.ReadKey();

        }
    }
}
