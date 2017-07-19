using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop
    {
    class ElectronicsShop
        {
        static void Main (string[] args)
            {
            int money, noOfKeyboards, noOfUSBs, i, j;
            var tokens = Console.ReadLine ().Split (' ');
            money = Int32.Parse (tokens[0]);
            noOfKeyboards = Int32.Parse (tokens[1]);
            noOfUSBs = Int32.Parse (tokens[2]);

            int[] keyboards =Array.ConvertAll(Console.ReadLine ().Split (' '),Int32.Parse);
            int[] USBs = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);

            Array.Sort (keyboards);   //sort both arrays in descending order
            Array.Reverse (keyboards);
            Array.Sort (USBs);
            Array.Reverse (USBs);

            int maxPurchase = 0;
            for ( i = 0; i < noOfKeyboards; i++ )
                {
                for ( j = 0; j < noOfUSBs; j++ )
                    {
                    if ( keyboards[i] + USBs[j] <= money && keyboards[i] + USBs[j] > maxPurchase )    //find the maximum purchase
                        {
                        maxPurchase = keyboards[i] + USBs[j];
                        }
                    }
                }
            if ( maxPurchase != 0 )    //print the result
                {
                Console.WriteLine (maxPurchase);
                }
            else
                {
                Console.WriteLine ("-1");
                }
            return;
            }
        }
    }
