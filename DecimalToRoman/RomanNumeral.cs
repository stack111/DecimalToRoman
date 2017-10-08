using System;

namespace DecimalToRoman
{
    /// <summary>
    /// Roman Numeral based class
    /// </summary>
    public class RomanNumeral
    {
        public string value { get; private set; }  
        public RomanNumeral(string numeral)
        {
            if(string.IsNullOrEmpty(numeral))
            {
                throw new ArgumentNullException(nameof(numeral));
            }
            value = numeral;
        }

        /// <summary> 
        /// Converts the roman numeral to decimal.
        /// </summary>
        public int ToDecimal()
        {
            string temp = value.ToLowerInvariant();
            char[] ch = temp.ToCharArray();
            
            return Recurse(ch, 0);
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

            if(current < next && chars[i+1] != chars[i])
            {
                // subtract
                return next - current;
            }
            else
            {
                // add
                // todo: how to deal with overflow?
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
