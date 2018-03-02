
namespace TextAnalyzer
{
    interface ITextAnalyzer
    {
        /// <summary>
        /// The number of characters in the given text.
        /// </summary>
        int CharacterCount { get; }

        /// <summary>
        /// The number of vowels in the given text.
        /// </summary>
        int VowelCount { get; }

        /// <summary>
        /// The number of consonants in the given text.
        /// </summary>
        int ConsonantCount { get; }

        /// <summary>
        /// The frequency of the string "the" in the given text. Not case sensitive.
        /// </summary>
        int FrequencyOfThe { get; }

        /// <summary>
        /// Return the given text with all the non-vowel characters filtered out.
        /// </summary>
        /// <returns>A single string with only vowels.</returns>
        string FilterNonVowels();
    }
}
