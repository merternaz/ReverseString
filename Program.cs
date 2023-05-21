using System;
using System.Collections.Generic;

namespace structures
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("kelime giriniz:");
            try{
                string entry=Console.ReadLine();
            }
            catch(FormatException e){
                Console.WriteLine("Hatalı format !");
            }
            
            
            ReverseWrite(entry);




        }

        public static void ReverseWrite(string s){

            for(int i=0;i<s.Length;i++){
                Console.Write(s[s.Length-1-i]);
            }

        }
    }
}