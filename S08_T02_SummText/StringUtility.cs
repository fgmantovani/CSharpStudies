using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S08_T02_SummText
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLenght = 20)
        {
            if (text.Length < maxLenght)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChar += word.Length + 1;

                if (totalChar > maxLenght)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + "...";

        }
    }
}
