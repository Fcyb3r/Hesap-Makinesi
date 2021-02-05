using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayi 5");
            Console.WriteLine("2. sayi 2");
            //Toplama islemi
            Console.WriteLine("Toplama islemi sonucu:" + toplama(5, 2));
            Console.WriteLine("Cıkarma islemi sonucu:" + cıkarma(5, 2));
            Console.WriteLine("Bolme islemi sonucu:" + bolme(5, 2));
            Console.WriteLine("Carpma islemi sonucu:" + carpma(5, 2));

        }

        //sayılar



        //toplama kods
        static int toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;


        }

        //cıkarma kods

        static int cıkarma(int sayi1, int sayi2)
        {

            return sayi1 - sayi2;



        }







        //carpma kods


        static int carpma(int sayi1, int sayi2) {


            return sayi1 * sayi2;
        
        
        }





        //bolme kods
        static float bolme(float sayi1, float sayi2)
        {

            return sayi1 / sayi2;



        }



    }



}
