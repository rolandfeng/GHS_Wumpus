using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadAndWriteFiles
{
    public partial class FileHelperTester : Form
    {
        /// <summary>
        /// Store the items for the tester
        /// </summary>
        private List<Item> items = new List<Item>();

        /// <summary>
        /// The default filename to load/save
        /// </summary>
        private string DefaultFilename = "items.txt";

        /// <summary>
        /// Constructor
        /// </summary>
        public FileHelperTester()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// AddItemButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // create item and add to list
            Item item = new Item();
            item.text = textInput.Text;
            int number = 0;
            if (Int32.TryParse(numberInput.Text, out number))
            {
                item.number = number;
            }
            item.date = dateTimePicker.Value;
            items.Add(item);

            // Display the items
            DisplayItems();
        }

        /// <summary>
        /// ClearItemsButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearItemsButton_Click(object sender, EventArgs e)
        {
            items.Clear();
            DisplayItems();            
        }

        /// <summary>
        /// Display Items
        /// Displays the items in the list box
        /// </summary>
        private void DisplayItems()
        {
            // clear existing items
            listBox.Items.Clear();

            // for each item, add it to the listBox
            foreach (Item item in items)
            {
                listBox.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// LoadFromFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();                       
            openFileDialog.FileName = DefaultFilename;

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // read items from file
                items = FileHelper.ReadFromFile(openFileDialog.FileName);                                
            }

            // Display the items
            DisplayItems();
        }

        /// <summary>
        /// SaveToFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = DefaultFilename;

            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileHelper.WriteToFile(saveFileDialog.FileName, items);
            }
        }        
    }
}
