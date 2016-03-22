using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexToDecimal
{
    public class HexToDecimal
    {

        

        private string littleEndain(string kartId)
        {
            string result = "";

            string _result = kartId.Substring(0, 8);

            for (int i = _result.Length ; i > 0; i--)
            {
                if (i%2!=0)
                {
                    result += _result.Substring(i-1 , 2);
                }
            }
            //10 B6 2B 84 00 00 00
            //10 B6 2B 84
            //84 2B B6 10
            //


            return result;
           
        }

        public long ConvertHexToDecimal(string hex)
        {
            string StrlittleEndain = littleEndain(hex);
            long result = 0;
            //result = int.Parse( StrlittleEndain , System.Globalization.NumberStyles.HexNumber);
            result = Convert.ToInt64(StrlittleEndain,16);
            return result;
        }


    }
}
