using System;

namespace yz_akademi_odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alice = 0, bob = 0;

            int[] aAlice = new int[3];
            int[] aBob = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alice dizi elemanlarını giriniz: ");
                aAlice[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bob dizi elemanlarını giriniz: ");
                aBob[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < 3; i++)
            {
                if(aAlice[i] > aBob[i])
                {
                    alice++;
                }
                if (aAlice[i] < aBob[i])
                {
                    bob++;
                }
                if (aAlice[i] == aBob[i])
                {
                    alice = alice;
                    bob = bob;
                }

                
            }
            Console.WriteLine("Alice'in puanı: "+ alice);
            Console.WriteLine("Bob'un puanı: "+ bob);
            Console.ReadLine();
            

        }


    }
}
