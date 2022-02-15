using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumCollection
{
    public partial class Form1 : Form
    {
        List<string> oOrder = new List<string>();
        List<string> sOrder = new List<string>();

        public Form1()
        {
            InitializeComponent();
            orginalOrderLabel.Text = "Original List ------------\n\n";
            sortedOrderLabel.Text = "Sorted List ------------\n\n";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string userInput = inputBox.Text;

            oOrder.Add(userInput);
            sOrder.Add(userInput);
            sOrder.Sort();

            //display info as it was orginally inputted
            orginalOrderLabel.Text = "Original List ------------\n\n";
            for (int i = 0; i < oOrder.Count(); i++)
            {
                orginalOrderLabel.Text += "\n" + oOrder[i];
            }

            //display info sorted alphabetically 
            sortedOrderLabel.Text = "Sorted List ------------\n\n";
            for (int i = 0; i < sOrder.Count(); i++)
            {
                sortedOrderLabel.Text += "\n" + sOrder[i];
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string userInput = inputBox.Text;
            outputLabel.Text = "";


            if (oOrder.Contains(userInput))
            {
                oOrder.Remove(userInput);
                sOrder.Remove(userInput);
                
                sOrder.Sort();

                //display info as it was orginally inputted
                orginalOrderLabel.Text = "Original List ------------\n\n";
                for (int i = 0; i < oOrder.Count(); i++)
                {
                    orginalOrderLabel.Text += "\n" + oOrder[i];
                }

                //display info sorted alphabetically 
                sortedOrderLabel.Text = "Sorted List ------------\n\n";
                for (int i = 0; i < sOrder.Count(); i++)
                {
                    sortedOrderLabel.Text += "\n" + sOrder[i];
                }

            }
            else
            {
                outputLabel.Text = "Please enter a valid name";
            }
        }
    }
}
