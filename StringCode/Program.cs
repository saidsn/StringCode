using System;

namespace StringCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Letter = { "s", "e", "i", "d" };
            Word(Letter);




        }
        static void Word(string[] Letter)

        {
            int count = 0;

            for (int i = 3; i < Letter.Length; i--)
            {
                count++;
                Console.WriteLine(Letter[i]);
            }
        }
           
            
              

        
            
        
    }
}
