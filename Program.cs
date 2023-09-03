using System;

namespace Ters
{
    class Program
    {
        static void Main(string[] args)
        {
            Array adi;
            Console.Write("Adınız :");
            adi = Console.ReadLine().ToCharArray();
            Array.Reverse(adi);           
            
            foreach (var karakter in adi)
            {
                Console.Write(karakter);
            }

            //  for(değişken tanımla ve başlangıç değeri ata; koşul belirt;arttırma azaltma yaptır){}
           
           
           /* for (int i = adi.Length-1; i >=0 ; i--)
            {
               Console.Write(adi[i]);
            }

            */

            
        }
    }
}
