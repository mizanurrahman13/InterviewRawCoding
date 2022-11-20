using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSetsExample
{
    public class SubSetDemo
    {
        public void Permute(string str, string option)
        {
            if (str.Length == 0)
            {
                Console.Write($"{option} ");
                return;
            }

            string changeToLower = ("" + str[0]).ToLower();
            string changeToUpper = ("" + str[0]).ToUpper();
            str = str.Substring(1);

            Permute(str, option + changeToLower);
            Permute(str, option + changeToUpper);
        }

        // Using BitWise Operation
        public void Permute(String input)
        {
            var length = input.Length;

            // Number of permutations is 2^length
            var max = 1 << length;

            input = input.ToLower();

            // using all subsequences and permuting them
            for (int i = 0; i < max; i++)
            {
                char[] combination = input.ToCharArray();

                for (int j = 0; j < length; j++)
                {
                    if (((i >> j) & 1) == 1)
                        combination[j] = (char)(combination[j] - 32);
                }

                Console.Write(combination);
                Console.Write(" ");
            }
        }
    }
}
