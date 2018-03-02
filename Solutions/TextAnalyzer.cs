using System;
using System.Text;

namespace TextAnalyzer
{
    public class TextAnalyzer : ITextAnalyzer
    {
        private string text;

        public TextAnalyzer(string text)
        {
            this.text = text;
        }

        public int CharacterCount
        {
            get 
            {
                return text.Length;
            }
        }

        public int VowelCount
        {
            get
            {
                int vowelCount = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (IsVowel(text[i]))
                    {
                        vowelCount++;
                    }
                }
                return vowelCount;
            }
        }

        public int ConsonantCount
        {
            get
            {
                int consonantCount = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (IsConsonant(text[i]))
                    {
                        consonantCount++;
                    }
                }
                return consonantCount;
            }
        }

        public int FrequencyOfThe
        {
            get
            {
                int count = 0;
                int idxCur = 0;
                while (true)
                {
                    int idxNext = text.IndexOf("the", idxCur, StringComparison.OrdinalIgnoreCase);
                    if (idxNext == -1)
                    {
                        return count;
                    }
                    idxCur = idxNext + 1;
                    count++;
                }
            }
        }

        public string FilterNonVowels()
        {
            StringBuilder sb = new StringBuilder(text.Length/2);
            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i]))
                {
                    sb.Append(text[i]);
                }
            }
            return sb.ToString();
        }

        private static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return ((c == 'a') ||
                    (c == 'e') ||
                    (c == 'i') ||
                    (c == 'o') ||
                    (c == 'u'));
        }

        private static bool IsConsonant(char c)
        {
            return (char.IsLetter(c) && !IsVowel(c));
        }
    }
}
