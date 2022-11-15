using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Xml.Schema;

namespace Num_to_Text_and_vice_versa
{
    public class num_to_text
    {
        public Dictionary<int, string> numList;
        public int thousand;
        public int million;
        public int billion;
        public int trillion;

        public num_to_text()
        {
            numList = new Dictionary<int, string>(){
            {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"},
            { 5, "five"},{6, "six" },{ 7, "seven"},{8, "eight"}, {9, "nine"},
            {10, "ten"},{11, "eleven"}, {12, "twelve"}, {13, "thirteen"},
            {14, "fourteen"}, { 15, "fifteen"}, {16, "sixteen"},
            {17, "seventeen"}, {18, "eighteen"},{ 19, "nineteen"}, {20, "twenty"},
            { 30, "thirty"}, {40, "forty"}, {50, "fifty"}, {60, "sixty"},
            { 70, "seventy"}, {80, "eighty"}, {90, "ninety"}
            };

            thousand = 1000;
            million = thousand * 1000;
            billion = million * 1000;
            trillion = billion * 1000;



        }
        public static string Numtotext(int num)
        {
            var myClass = new num_to_text();
            Dictionary<int, string> numList1 = myClass.numList;
            int thousand1 = myClass.thousand;
            int million1 = myClass.million;
            int billion1 = myClass.billion;
            int trillion1 = myClass.trillion;
            

            

            if (num < 20)
            {
                return numList1[num];
            }else if (num < 100)
            {
                if (num % 10 == 0)
                {
                    return numList1[num];
                }
                else
                {
                    return numList1[num / 10 * 10] + '-' + numList1[num % 10];
                }

            }
            else if (num < thousand1)
            {
                
                if (num % 10 == 0) {
                    return numList1[num / 100] + " hundred";
                }
                else
                {
                    return numList1[num / 100] + " hundred and " + Numtotext(num % 100);
                }
            }

            else if (num < million1)
            {
                if (num % thousand1 == 0)
                {
                    return Numtotext(num / thousand1) + " thousand";
                }
                else
                {
                    return Numtotext(num / thousand1) + " thousand, " + Numtotext(num % thousand1);
                }
            }

            else if (num < billion1)
            {
                if ((num % million1) == 0)
                {
                    return Numtotext(num / million1) + " million";
                }
                else
                {
                    return Numtotext(num / million1) + " million, " + Numtotext(num % million1);
                }
            }

            else if (num < trillion1) {
                if ((num % billion1) == 0)
                    return Numtotext(num / billion1) + " billion";
                else {
                    return Numtotext(num / billion1) + " billion, " + Numtotext(num % billion1);
                }
            }

            else if (num % trillion1 == 0)
            {
                return Numtotext(num / trillion1) + " trillion";
            }
            else
            {
                return Numtotext(num / trillion1) + " trillion, " + Numtotext(num % trillion1);
            }

        }

    }
}
