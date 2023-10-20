using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShustovTS.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string result = value;
            foreach (char letter in value)
            {
                if (letter == replaceable)
                {
                    result = result.Replace(replaceable, replacement);
                }
            }
            return result;
        }
    }
}
