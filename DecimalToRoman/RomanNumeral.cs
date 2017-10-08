using System;

namespace DecimalToRoman
{
    public class RomanNumeral
    {
        string _numeral;
        public RomanNumeral(string numeral)
        {
            _numeral = numeral;
        }
        public int ToDecimal()
        {
            string temp = _numeral.ToLowerInvariant();
            char[] ch = temp.ToCharArray();
            
            int value = Recurse(ch, 0);

            return value;
        }

        private int Recurse(char[] chars, int i)
        {
            if(i == chars.Length)
            {
                return 0;
            }

            // vx
            int next = Recurse(chars, i+1);
            int current = NumeralToDecimal(chars[i]);
            if(current < next)
            {
                // subtract
                return next - current;
            }
            else
            {
                // add
                return current + next;
            }
        }

        private int NumeralToDecimal(char c)
        {
            switch(c)
            {
                case 'i': return 1;
                case 'v': return 5;
                case 'x': return 10;
                case 'l': return 50;
                case 'c': return 100;
                case 'd': return 500;
                case 'm': return 1000;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
