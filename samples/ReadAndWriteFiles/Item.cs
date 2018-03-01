using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWriteFiles
{
    public class Item
    {
        public string text;
        public int number;
        public DateTime date;

        /// <summary>
        /// Override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Text: " + text + "; Number: " + number + "; Date: " + date;
        }
    }
}
