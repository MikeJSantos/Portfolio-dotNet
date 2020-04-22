using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public class BackspaceCompare
    {
        public static bool Run(string S, string T)
        {
            var parsedS = ParseBackspace(S);
            var parsedT = ParseBackspace(T);

            var retVal = parsedS.Equals(parsedT);

            Console.Out.WriteLine($"'{S}' => '{parsedS}' | '{T}' => '{parsedT}' == {retVal}");
            return retVal;
        }

        private static string ParseBackspace(string str)
        {
            var backspaceCounter = 0;
            var characterStack = new Stack<char>();

            for (var i = str.Length - 1; i >= 0; i--)
            {
                var character = str[i];

                if (character == '#')
                {
                    backspaceCounter++;
                }
                else if (backspaceCounter > 0)
                {
                    backspaceCounter--;
                }
                else
                {
                    characterStack.Push(character);
                }
            }

            return new String(characterStack.ToArray());            
        }
    }
}