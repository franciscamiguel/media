using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            int media = 0;
            int idade1 = 5;
            int idade2 = 7;
            int idade3 = 9;
            int idade4 = 11;
            int idade5 = 13;
            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine(" A idade média dos alunos é " + media);
            Console.ReadKey();
        }
    }        
}  