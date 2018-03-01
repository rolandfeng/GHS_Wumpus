using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWriteFiles
{
    /// <summary>
    /// A helper class for reading/writing a list of items from/to a file
    /// 
    /// An item consists of 3 parts: some text, a number, and a date
    /// 
    /// The file format is as follows:
    /// * each line of the file represents a separate item from the list
    /// * each line has all 3 parts of the item, using a semicolon as the delimiter as follows:    
    /// text;number;date
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// The number of segments in an item
        /// </summary>
        private const int SegmentsPerItem = 3;

        /// <summary>
        /// Writes the items to the specified file
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="items"></param>
        public static void WriteToFile(string filename, List<Item> items)
        {
            // create a list of strings to represent each line
            List<string> lines = new List<string>();

            // for each item in the items list...
            foreach (Item item in items)
            {
                // prepare the line
                string line = item.text + ";" + item.number + ";" + item.date;

                // add the line to the lines list
                lines.Add(line);
            }

            // since the WriteAllLines method needs an array, convert the list to an array
            string[] linesArray = lines.ToArray();

            // write the lines to the file
            File.WriteAllLines(filename, linesArray);
        }

        /// <summary>
        /// Reads the contents of the specified file into a list of items
        /// </summary>
        /// <param name="filename">The file name to read from</param>
        /// <returns>A list of items</returns>
        public static List<Item> ReadFromFile(string filename)
        {
            // create an items list to hold the items.  This is what we'll be returning.
            List<Item> items = new List<Item>();

            // read all lines from the file into a string array
            string[] lines = File.ReadAllLines(filename);

            // for each line in the file...
            foreach (string line in lines)
            {
                // parse the contents of the line using the semicolon delimiter
                string[] segments = line.Split(';');

                // verify that this line has the right number of segments
                if (segments.Count() != SegmentsPerItem)
                {
                    throw new Exception("Wrong number of segments encountered.  File is corrupt.");
                }
                
                // create a new item
                Item item = new Item();

                // set the text from the first segment
                item.text = segments[0];

                // set the number from the second segment
                item.number = Int32.Parse(segments[1]);                

                // set the date from the third segment
                item.date = DateTime.Parse(segments[2]);

                // add item to items list
                items.Add(item);
            }

            // return the items list
            return items;
        }
    }
}
