//Word starts with a vowel 
//Word doesn't start a vowel but has one in it 
//Word has no vowel (we don't treat y as vowel) 

namespace PigLatin
{
    public class Program
    {
        public static void Main()
        {
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Please input a word to translate into Pig Latin");

                string input = Console.ReadLine().Trim();

                //This is good practice, C# tends to return empty strings, but other language would return null here
                if (input != "" && input != null)
                {
                    string[] words = input.Split(' ');
                    string translatedSentence = "";
                    foreach (string word in words)
                    {
                        if (HasNum(word) || HasSymbols(word))
                        {
                            Console.WriteLine("This word has numbers or symbols so we are leaving it be");
                            translatedSentence += word + " ";
                        }
                        else
                        {
                            translatedSentence += Translate(word) + " ";
                        }
                        // Console.WriteLine(translated);
                    }
                    Console.WriteLine(translatedSentence);
                }
                else
                {
                    Console.WriteLine("Input was empty so nothing was translated");
                }

                goOn = Continue();
            }
        }

        public static bool HasNum(string input)
        {
            //strings are just character arrays, hence why I can put one into a foreach 
            foreach(char let in input)
            {
                if (char.IsDigit(let))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasSymbols(string input)
        {
            char[] symbols = { '@', '.', ',', '*', '%', '#' };

            foreach(char let in input)
            {
                if (symbols.Contains(let))
                {
                    return true;
                }
            }

            return false;
        }

        public static string Translate(string input)
        {
            int firstVowelIndex = FirstVowelIndex(input);
            Console.WriteLine(firstVowelIndex);

            string translated = "";
            if (firstVowelIndex == 0)
            {
                //This means our word starts with a vowel 
                translated = input + "way";
            }
            else if (firstVowelIndex == -1)
            {
                Console.WriteLine("This word can't be translated, no vowels were found");
            }
            else
            {
                string prefix = input.Substring(0, firstVowelIndex);
                string postfix = input.Substring(firstVowelIndex);
                Console.WriteLine(prefix);
                Console.WriteLine(postfix);
                translated = postfix + prefix + "ay";
            }

            return translated;
        }

        public static int FirstVowelIndex(string word)
        {
            for(int i = 0; i < word.Length; i++)
            {
                //Why am I able to look at the character in my string like an array?
                char c = word[i];
                if (IsVowel(c))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            c = char.ToLower(c);
            if (vowels.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to translate another word? y/n");
            string input = Console.ReadLine().ToLower().Trim();
            
            if(input == "y")
            {
                return true;
            }
            else if(input== "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand your input, let's try that again");
                return Continue();
            }
        }
    }
}
