﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Super
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = "Supercalifragilisticexpialidocious";


            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine();

            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if(letter == 'L')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
            int count = 0;
            foreach (char letter in word)
            {
                count++;
            }
            Console.WriteLine(count);

            Console.WriteLine(word.Length);

        
        
        Console.ReadKey(); 
            
        }
    }
}
    


