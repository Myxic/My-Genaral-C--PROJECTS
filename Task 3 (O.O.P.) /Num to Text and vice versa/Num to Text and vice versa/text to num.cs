using System;
using System.Collections;
using System.Collections.Generic;

namespace Num_to_Text_and_vice_versa
{
    public class text_to_num
    {
        public List<string> units;
        public List<string> tens;
        public List<string> scales;
        public string numword("and");

        public text_to_num()
        {
            units = new List<string> {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
            "sixteen", "seventeen", "eighteen", "nineteen",
        };

            tens = new List<string> { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            scales = new List<string>{"hundred", "thousand", "million", "billion", "trillion"};

            numword["word"] = (1, 0);
        }


            

        
	}
}
