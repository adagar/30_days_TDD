using System;


namespace CharCounterLibrary
{ 
    public class CharCounter
    {
        public static int CountChar(string input, char scanTarget)
        {
            var numOfOccurences = 0;
            foreach(var letter in input)
            {
                if(letter == scanTarget)
                {
                    numOfOccurences++;
                }
            }
            return numOfOccurences;
        }

    }
    
}
