using System;
using System.Collections.Generic;

namespace Morse
{
    public enum Languages
    {
        English,
        Russian
    }
    public static class ClassMorse
    {
        public static Dictionary<string, string> ENG_MORSE = new Dictionary<string, string>
        { { "A", ".-" }, { "B", "-..." }, { "C", "-.-." }, { "D", "-.." },
            { "E", "." }, { "F", "..-." }, { "G", "--." }, { "H", "...." },
            { "I", ".." }, { "J", ".---" }, { "K", "-.-" }, { "L", ".-.." },
            { "M", "--" }, { "N", "-." }, { "O", "---" }, { "P", ".--." },
            { "Q", "--.-" }, { "R", ".-." }, { "S", "..." }, { "T", "-" },
            { "U", "..-" }, { "V", "...-" }, { "W", ".--" }, { "X", "-..-" },
            { "Y", "-.--" }, { "Z", "--.." }, { "1", ".----" }, { "2", "..---" },
            { "3", "...--" }, { "4", "....-" }, { "5", "....." }, { "6", "-...." },
            { "7", "--..." }, { "8", "---.." }, { "9", "----." }, { "0", "-----" } };

        public static Dictionary<string, string> MORSE_ENG = new Dictionary<string, string>
        { {".-" , "A"},{"-..." , "B"},{"-.-." , "C"},{"-.." , "D"},{"." , "E"},
            {"..-." , "F"},{"--." , "G"},{"...." , "H"},{".." , "I"},{".---" , "J"},
            {"-.-" , "K"},{".-.." , "L"},{"--" , "M"},{"-." , "N"},{"---" , "O"},
            {".--." , "P"},{"--.-" , "Q"},{".-." , "R"},{"..." , "S"},{"-" , "T"},
            {"..-" , "U"},{"...-" , "V"},{".--" , "W"},{"-..-" , "X"},{"-.--" , "Y"},
            {"--.." , "Z"},{".----" , "1"},{"..---" , "2"},{"...--" , "3"},{"....-" , "4"},
            {"....." , "5"},{"-...." , "6"},{"--..." , "7"},{"---.." , "8"},{"----." , "9"},{"-----" , "0"}};

        public static Dictionary<string, string> RUS_MORSE = new Dictionary<string, string>
        { { "А", ".-" }, { "Б", "-..." }, { "Ц", "-.-." }, { "Д", "-.." },{ "Ъ", ".--.-." },
            { "Е", "." }, { "Ф", "..-." }, { "Г", "--." }, { "Х", "...." },{ "Ч", "---." },
            { "И", ".." }, { "Й", ".---" }, { "К", "-.-" }, { "Л", ".-.." },{ "Ш", "----" },
            { "М", "--" }, { "Н", "-." }, { "О", "---" }, { "П", ".--." },{ "Э", "..-.." },
            { "Щ", "--.-" }, { "Я", ".-.-" }, { "С", "..." }, { "Т", "-" },{ "Ю", "..--" },
            { "У", "..-" }, { "Ж", "...-" }, { "В", ".--" }, { "Ь", "-..-" }, { "Р", ".-." },
            { "Ы", "-.--" }, { "З", "--.." }, { "1", ".----" }, { "2", "..---" },
            { "3", "...--" }, { "4", "....-" }, { "5", "....." }, { "6", "-...." },
            { "7", "--..." }, { "8", "---.." }, { "9", "----." }, { "0", "-----" } };

        public static Dictionary<string, string> MORSE_RUS = new Dictionary<string, string>
        { { ".-", "А" }, { "-...", "Б" }, { "-.-.", "Ц" }, { "-..", "Д" }, { ".--.-.", "Ъ" },
            { ".", "Е" }, { "..-.", "Ф" }, { "--.", "Г" }, { "....", "Х" }, { "---.", "Ч" },
            { "..", "И" }, { ".---", "Й" }, { "-.-", "К" }, { ".-..", "Л" }, { "----", "Ш" },
            { "--", "М" }, { "-.", "Н" }, { "---", "О" }, { ".--.", "П" }, { "..-..", "Э" },
            { "--.-", "Щ" }, { ".-.-", "Я" }, { "...", "С" }, { "-", "Т" }, { "..--", "Ю" },
            { "..-", "У" }, { "...-", "Ж" }, { ".--", "В" }, { "-..-", "Ь" }, { ".-.", "Р" },
            { "-.--", "Ы" }, { "--..", "З" }, { ".----", "1" }, { "..---", "2" }, { "...--", "3" },
            { "....-", "4" }, { ".....", "5" }, { "-....", "6" }, { "--...", "7" }, { "---..", "8" },
            { "----.", "9" }, { "-----", "0" }};
        /// <summary>
        /// Конвертирует символ данного языка в код Морзе
        /// </summary>
        /// <param name="letter">Буква</param>
        /// <param name="language">Язык</param>
        /// <returns>строка из точек и тире</returns>
        public static string ConvertToMorse(char letter, Languages language)
        {
            string normalizedLetter = char.ToUpper(letter).ToString();
            if (language == Languages.English)
            {
                if (ENG_MORSE.ContainsKey(normalizedLetter))
                    return ENG_MORSE[normalizedLetter];
                return "";
            }
            else
            {
                if (RUS_MORSE.ContainsKey(normalizedLetter))
                    return RUS_MORSE[normalizedLetter];
                return "";
            }
        }
        /// <summary>
        /// Конвертирует из кода Морзе в данный язык
        /// </summary>
        /// <param name="s">Строка из точек и тире</param>
        /// <param name="language">Язык</param>
        /// <returns>Cтрока на данном языке</returns>
        public static string ConvertFromMorse(string s, Languages language)
        {
            if (language == Languages.English)
            {
                if (MORSE_ENG.ContainsKey(s))
                    return MORSE_ENG[s];
                return "";
            }
            else
            {
                if (MORSE_RUS.ContainsKey(s))
                    return MORSE_RUS[s];
                return "";
            }
        }
    }
}
