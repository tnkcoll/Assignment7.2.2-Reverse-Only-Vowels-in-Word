namespace Assignment7._2._2_Reverse_Only_Vowels_in_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "avacado";
            Console.WriteLine(word);
            Console.WriteLine(ReverseVowels(word));
        }

        static string ReverseVowels(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            s = s.ToLower();

            //Converted the string to a char array so the left and right variables can be used as elements.
            char[] letters = s.ToCharArray();

            while (left < right)
            {
                //If both left and right elements of the char array "letters" both contain a vowel, then swap the values at those elements.
                if (ContainsVowel(letters[left]) && ContainsVowel(letters[right]))
                {
                    //Perform the swap.
                    char temp = letters[left];
                    letters[left] = letters[right];
                    letters[right] = temp;

                    left++;
                    right--;
                }
                else
                {
                    //If the avlue in the left element of char array "letters" is not a vowel, increment left.
                    if (!ContainsVowel(letters[left]))
                    {
                        left++;
                    }

                    //If the avlue in the right element of char array "letters" is not a vowel, increment right.
                    if (!ContainsVowel(letters[right]))
                    {
                        right--;
                    }
                }
            }

            return new string(letters);
        }

        static bool ContainsVowel(char c)
        {
            //Return true if the char is a vowel, return false if it is not.
            return "aeiou".Contains(c);
        }
    }
}
