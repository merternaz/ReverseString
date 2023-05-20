using System;
using System.Collections.Generic;

namespace structures
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("kelime giriniz:");
            string entry=Console.ReadLine();
            
            ReverseWrite(entry);




        }

        public static void ReverseWrite(string s){

            for(int i=0;i<s.Length;i++){
                Console.Write(s[s.Length-1-i]);
            }

        }
    }
}