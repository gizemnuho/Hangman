using System;
using System.Collections.Generic;
using System.Linq;

namespace WordGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "hello";
            int maxLives = 7;
            int currentLives = maxLives;
            bool win = false;
            List<char> guessedLetters = new List<char>();

            while (currentLives > 0 && !win)
            {
                Console.WriteLine(); // boş satır

                // Kelimeyi ekrana çizgili ve tahminli göster
                foreach (char c in word)
                {
                    if (guessedLetters.Contains(c))
                        Console.Write(c + " ");
                    else
                        Console.Write("_ ");
                }

                Console.WriteLine("\n\nPlease guess a letter!");
                Console.WriteLine(currentLives + "/" + maxLives + " lives remaining.");

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    continue;

                char guess = input.ToLower()[0]; // Küçük harfe çevir

                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("You already guessed that letter!");
                    continue;
                }

                guessedLetters.Add(guess);

                if (word.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    currentLives--;
                }

                // Tüm harfler tahmin edildiyse kazan
                bool wordComplete = true;
                foreach (char c in word)
                {
                    if (!guessedLetters.Contains(c))
                    {
                        wordComplete = false;
                        break;
                    }
                }

                win = wordComplete;
            }

            Console.WriteLine();
            if (win)
                Console.WriteLine(" Congratulations, you win!");
            else
                Console.WriteLine(" You lose... The word was: " + word);

            Console.ReadKey();
        }
    }
}
