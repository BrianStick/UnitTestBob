using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestBob
{
    public class Bob
    {
        public string Hey(string remark)
        {
            if (remark.Trim() == "")
            {
                return "Fine. Be that way!";
            }
            if (IsYelling(remark))
            {
                return "Whoa, chill out!";
            }
            if (remark.EndsWith("?"))
            {
                return "Sure.";
            }

            return "Whatever.";
        }

        internal string hey(string remark)
        {
            throw new NotImplementedException();
        }

        public bool IsYelling(string input)
        {
            if (input.Any(c => char.IsDigit(c) && input.EndsWith("!")))
            {
                return true;
            }

            var input2 = input;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    input2 = input.Replace(input[i], '@');
                }
            }

            if (input2 == input.ToUpper())
            {
                return true;
            }

            return false;
        }
    }





