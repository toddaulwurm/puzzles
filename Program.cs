using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("[{0}]", string.Join(",", RandomArray()));
            // Console.WriteLine(TossCoin());
            // Console.WriteLine(TossMultipleCoins(5));
            // Console.WriteLine("[{0}]", string.Join("," ,(Names())));
        }
        // public static int[] RandomArray()
        // { 
        //     Random rand = new Random();
        //     int[] arr = new int[10];
        //     for(int i = 0; i<10; i++)
        //     {
        //         arr[i] = rand.Next(5,25);
        //     }
        //     int[] mms = new int[3];
        //     int max = arr[0];
        //     int min = arr[0];
        //     int sum = 0;
        //     for(int i =0; i<10; i++)
        //     {
        //         if(arr[i]>max)
        //         {
        //             max = arr[i];
        //         }
        //         else if(arr[i]<min)
        //         {
        //             min = arr[i];
        //         }
        //         sum+=arr[i];
        //     }
        //     mms[0] = max;
        //     mms[1] = min;
        //     mms[2] = sum;
        //     return mms;
        // }



        // public static string TossCoin()
        // {
        //     Console.WriteLine("Tossing A Coin!");
        //     Random rand = new Random();
        //     int coin = rand.Next(2);
        //     if(coin==1)
        //     {   
        //         Console.WriteLine("Heads!");
        //         return "Heads!";
        //     }
        //     else
        //     {   
        //         Console.WriteLine("Tails!");
        //         return "Tails!";
        //     }
        // }
        // public static double TossMultipleCoins(int num)
        // {   
        //     double tails = 0;
        //     double heads = 0;
        //     double ratio = 0;
        //     for(int i=0; i<num; i++)
        //     {
        //         string result = TossCoin();
        //         if(result=="Tails!")
        //         {
        //             tails += 1;
        //         }
        //         if(result=="Heads!")
        //         {
        //             heads += 1;
        //         }
        //     }
        //     if(tails<heads)
        //     {
        //         ratio = tails/heads;
        //     }
        //     if(heads<tails)
        //     {
        //         ratio = heads/tails;
        //     }
        //     Console.WriteLine($"heads={heads} tails={tails}");
        //     return ratio;
        // }



        // public static List<string> Names()
        // {   
        //     List<string> namelist = new List<string>();
        //     namelist.Add("Todd");
        //     namelist.Add("Tiffany");
        //     namelist.Add("Charlie");
        //     namelist.Add("Geneva");
        //     namelist.Add("Sydney");
        //     Random rand = new Random();
        //     for(int i=5; i>=0; i--)
        //     {   
        //         int chameleon = rand.Next(i);
        //         namelist.Add(namelist[chameleon]);
        //         namelist.RemoveAt(chameleon);
        //     }
        //     for(int i = 0; i<namelist.Count; i++)
        //     {
        //         if(namelist[i].Length < 5)
        //         {
        //             namelist.Remove(namelist[i]);
        //         }
        //     }


        //     return namelist;
        }
    }
}
