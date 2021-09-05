using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            bool guessed = false; 
            int attempts = 0; // Define as tentativas do user. Aumenta quando o mesmo insere um número.
            int totalAttempts = 3; // Define o número de tentativas que o user tem para acerta o número.

            Random rand = new Random();
            int randomNumber = rand.Next(0, 11); // Define o número aleatório entre 0 e 10.

            Console.WriteLine("Vais ter de adivinhar um número entre 0 e 10");
            
            while (!guessed)
            {
                Console.WriteLine("Escolhe: ");
                string userNumber = Console.ReadLine();

                // Converte a variável "userNumber" num integer.
                // Se não o fizermos, será impossível fazer a comparação com o número aleatório.
                int intUserNumber = Int32.Parse(userNumber); 

                attempts++; // Aumenta em 1 o número de tantivas do user.

                /* 
                 * Define as condições para verificar se o user acertou ou não e para verificar se esgotou as tentativas.
                 * Se o número introduzido pelo user for diferente do número aleatório avisamos o mesmo, porém não terminamos o loop até que
                 * se tenham esgotado as tentativas ou até que tenha acertado o número sem esgotar as tentativas
                */
                if (intUserNumber < randomNumber)
                {
                    Console.WriteLine("Hum... Mais alto!");
                }
                                    
                if (intUserNumber > randomNumber)
                {
                    Console.WriteLine("Hum... Mais Baixo!");
                }
                                   
                if (intUserNumber == randomNumber)
                {
                    guessed = true;
                }
                                    
                if (attempts == totalAttempts)
                {
                    Console.WriteLine("Esgotaste as tuas tentativas. Perdeste! O número era o {0}", randomNumber);
                    break;
                }   
            }
            if (guessed)
            {
                Console.WriteLine("Parabéns, acertaste!");
            }
        }
    }
}
