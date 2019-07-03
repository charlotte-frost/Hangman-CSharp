using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = { "awkward", "attempt", "border", "customs", "disscussion", "essential", "exchange", "fireplace",
                "floating", "garage", "grandmother", "heading", "independant", "instant", "mathematics", "memory",
                "mysterious", "occasionally", "offical", "positive", "practical", "promised", "remarkable", "require",
                "satisfied", "scared", "selection", "shallow", "slight", "species", "thumb", "tobacco", "treates",
                "vessels", "jazz", "duff", "junk", "buzzer", "babes", "buzzing", "faffed", "zap", "hockey", "password",
                "lawnmower", "mailman", "dominos", "treasure", "computer", "america", "photograph", "hockey", "key",
                "mattress", "battery", "electricity", "circus", "cardboard", "sandbox", "birthday", "zipper", "internet",
                "koala", "dentist", "stomach", "pineapple", "sprinkler", "suitcase", "mushroom", "camera", "ticket",
                "newspaper", "pajamas", "quilt", "beach", "snowball", "dollar", "boot", "clam", "pretzel", "rainbow",
                "blowfish", "stingray", "pelican", "garden", "chalk", "swing", "gallop", "blacksmith", "tournament",
                "exponential", "century", "kilogram", "overdue", "vision", "lyrics", "ligament", "siesta", "pastry",
                "gallop" };

            generateWord(word);
        }
        static void generateWord (string[] word)
        {
            int lengthOfArray = word.Length;
            Random rand = new Random();
            int positionOfWord = rand.Next(0, lengthOfArray);
            string randomWord = word[positionOfWord];
           // Console.WriteLine("Position is : " + positionOfWord);
            //Console.WriteLine("word is : "+randomWord);
           // Console.ReadLine();
            removeWord(word, lengthOfArray, positionOfWord, randomWord);

        }
        static void removeWord(string [] word, int lengthOfArray, int positionOfWord, string randomWord)
        {
            for (int i = positionOfWord; i<lengthOfArray-1;i++)
            {
                word[i] = word[i + 1];
            }
            word[lengthOfArray-1] = null;
            //Console.WriteLine("Deleted position ");
            lengthOfArray = lengthOfArray - 1;
            setUpConsole(word, lengthOfArray, positionOfWord, randomWord);
            //printArray(word, lengthOfArray, positionOfWord, randomWord);
        }
        static void printArray(string[] word, int lengthOfArray, int positionOfWord, string randomWord)
        {
            for(int i =0; i<lengthOfArray;i++)
            {
                Console.WriteLine(word[i]);
            }
            Console.ReadLine();
        }
        static void setUpConsole(string[] word, int lengthOfArray, int positionOfWord, string randomWord)
        {
            string[] alpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] letterFoundPosition = new string[20];
            for (int i = 0; i<randomWord.Length;i++)
            {
                letterFoundPosition[i] = "-1";
            }
            Console.Write("            \n            \n            \n            \n            \n            \n            \n              ");
            for (int i = 0; i < randomWord.Length; i++)
            {
                Console.Write(" __ ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i<alpha.Length;i++)
            {
                Console.Write( "  " + alpha[i]+ "  ");
            }
            //Console.ReadLine();
            Console.WriteLine();
            int count = 0;
            int length = 0;

            userGuess(word, lengthOfArray, positionOfWord, randomWord, letterFoundPosition, count, alpha, length);
        }
        static void userGuess(string[] word, int lengthOfArray, int positionOfWord, string randomWord, string[] letterFoundPosition, int count, string[] alpha, int length)
        {
            Console.WriteLine("Enter the letter you want to guess :");
            char guess = Convert.ToChar(Console.ReadLine());
            char[] charArray = randomWord.ToCharArray();
            bool doesContain = false;
            
            for (int i =0; i< randomWord.Length;i++)
            {
                if (charArray[i] == guess)
                {
                    letterFoundPosition[i] = "1";
                    doesContain = true;
                    length = length + 1;
                }
                else if (letterFoundPosition[i] != "1" || letterFoundPosition[i] != "-1")
                {
                    letterFoundPosition[i] = letterFoundPosition[i];
                }
                else 
                {
                    letterFoundPosition[i] ="-1";
                }
            }
            if (doesContain == false)
            {
                count = count + 1;
            }
            findChar(word, lengthOfArray, positionOfWord, randomWord, guess, charArray, letterFoundPosition,  count, doesContain, alpha, length);   
        }
        static void findChar(string[] word, int lengthOfArray, int positionOfWord, string randomWord, char guess, char[] charArray, string [] letterFoundPosition ,int count, bool doesContain, string[] alpha, int length)
        {
            string letter = null;
            if (guess == 'a')
            {
                letter = "a";
            }
            else if (guess == 'b')
            {
                letter = "b";
            }
            else if (guess == 'c')
            {
                letter = "c";
            }
            else if (guess == 'd')
            {
                letter = "d";
            }
            else if (guess == 'e')
            {
                letter = "e";
            }
            else if (guess == 'f')
            {
                letter = "f";
            }
            else if (guess == 'g')
            {
                letter = "g";
            }
            else if (guess == 'h')
            {
                letter = "h";
            }
            else if (guess == 'i')
            {
                letter = "i";
            }
            else if (guess == 'j')
            {
                letter = "j";
            }
            else if (guess == 'k')
            {
                letter = "k";
            }
            else if (guess == 'l')
            {
                letter = "l";
            }
            else if (guess == 'm')
            {
                letter = "m";
            }
            else if (guess == 'n')
            {
                letter = "n";
            }
            else if (guess == 'o')
            {
                letter = "o";
            }
            else if (guess == 'p')
            {
                letter = "p";
            }
            else if (guess == 'q')
            {
                letter = "q";
            }
            else if (guess == 'r')
            {
                letter = "r";
            }
            else if (guess == 's')
            {
                letter = "s";
            }
            else if (guess == 't')
            {
                letter = "t";
            }
            else if (guess == 'u')
            {
                letter = "u";
            }
            else if (guess == 'v')
            {
                letter = "v";
            }
            else if (guess == 'w')
            {
                letter = "w";
            }
            else if (guess == 'x')
            {
                letter = "x";
            }
            else if (guess == 'y')
            {
                letter = "y";
            }
            else if (guess == 'z')
            {
                letter = "z";
            }
            
            for (int i =0; i<alpha.Length; i++)
            {
                if (alpha[i] == letter)
                {
                    alpha[i] = " ";
                }
            }
            hangmanConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition,count, doesContain, alpha, length);
        }
        static void newConsole(string[] word, int lengthOfArray, int positionOfWord, string randomWord, char guess, string letter, char[] charArray, string[] letterFoundPosition, int count, bool doesContain, string [] alpha, int length)
        {
            for (int i =0; i< randomWord.Length;i++)
            {
                if(letterFoundPosition[i] == "-1")
                {
                    Console.Write(" __ ");
                }
                else if (letterFoundPosition[i] == "1")
                {
                    letterFoundPosition[i] = letter;
                    Console.Write("  "+guess+"  ");
                }
                else if (letterFoundPosition[i] != "-1" || letterFoundPosition[i] != "1")
                {
                    Console.Write("  " + letterFoundPosition[i] + "  ");
                }
            }

            Console.WriteLine("\n");
            for (int i =0; i< alpha.Length;i++)
            {
                Console.Write(" " + alpha[i] + " ");
            }
            //Console.ReadLine();
            Console.WriteLine("\n ");


            if(length == randomWord.Length)
            {
                Console.WriteLine("Congrats you have guessed correctly!!");
                Console.WriteLine("Would you like to play again?(y/n)");
                string playAgain = Console.ReadLine();
                if(playAgain.ToLower() == "y")
                {
                    generateWord(word);
                }
                else
                {
                    endGame();
                }
                //Console.ReadLine();
            }
            else
            {
                userGuess(word, lengthOfArray, positionOfWord, randomWord, letterFoundPosition, count, alpha, length);
            }
          }
        static void hangmanConsole(string[] word, int lengthOfArray, int positionOfWord, string randomWord, char guess, string letter, char[] charArray, string[] letterFoundPosition, int count, bool doesContain, string [] alpha, int length)
        {
           
            if (count==0)
            {
                Console.Write(
                   "              \n" +
                   "              \n" +
                   "              \n" +
                   "              \n" +
                   "              \n" +
                   "              \n" +
                   "              \n" +
                   "              \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else if (count ==1)
            {
                Console.Write(
                    "__________    \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else if (count == 2)
            {
                Console.Write(
                    "__________    \n" +
                    "|        |    \n" +
                    "|        O    \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else if(count ==3)
            {
                Console.Write(
                    "__________    \n" +
                    "|        |    \n" +
                    "|        O    \n" +
                    "|        |    \n" +
                    "|        |    \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else if (count == 4)
            {
                Console.Write(
                    "__________    \n" +
                    "|        |    \n" +
                    "|        O    \n" +
                    "|       /|    \n" +
                    "|        |    \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else if (count == 5)
            {
                Console.Write(
                    "__________    \n" +
                    "|        |    \n" +
                    "|        O    \n" +
                    "|       /|/  \n" +
                    "|        |    \n" +
                    "|             \n" +
                    "|             \n" +
                    "|             \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else if (count == 6)
            {
                Console.Write(
                    "__________    \n" +
                    "|        |    \n" +
                    "|        O    \n" +
                    "|       /|/  \n" +
                    "|        |    \n" +
                    "|       /     \n" +
                    "|             \n" +
                    "|             \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else if (count == 7)
            {
                Console.Write(
                    "__________    \n" +
                    "|        |    \n" +
                    "|        O    \n" +
                    "|       /|/  \n" +
                    "|        |    \n" +
                    "|       / /  \n" +
                    "|             \n" +
                    "|             \n");
                newConsole(word, lengthOfArray, positionOfWord, randomWord, guess, letter, charArray, letterFoundPosition, count, doesContain, alpha, length);
            }
            else
            {
                Console.WriteLine("You have run out of guesses.\nThe word was "+ randomWord +"... You loose!!");
                Console.ReadLine();
                endGame();
            }
        }
        static void endGame()
        {

        }
    }
}
