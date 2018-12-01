// Chad Weirick
// CST-117
// Grand Canyon Univeristy
// Dr. J's class!
//
// Programming Project 2:
// Requirements : Write a Windows Forms program that uses radio buttons, check boxes and list boxes.  
//
// Program goal: create a password generator.
// Check boxes determine what types of characters can be added
// radio buttons determine whether one or five passwords are created
// the list box is used for output
// in a bonus twist, I experimented with disabling buttons in an appropriate way
// I also used selected items from the list as well as a system clipboard copy


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Programming_Project_2
{
    public partial class passGenMainWindow : Form
    {

        public passGenMainWindow()
        {
            InitializeComponent();
            copyButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            generateOnePassRadioButton.Checked = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {

            // create a list to handle the possible chars to be selected
            List<char> possibleChars = new List<char>();
            possibleChars.Add('a');
            possibleChars.Add('b');
            possibleChars.Add('c');
            possibleChars.Add('d');
            possibleChars.Add('e');
            possibleChars.Add('f');
            possibleChars.Add('g');
            possibleChars.Add('h');
            possibleChars.Add('i');
            possibleChars.Add('j');
            possibleChars.Add('k');
            possibleChars.Add('l');
            possibleChars.Add('m');
            possibleChars.Add('n');
            possibleChars.Add('o');
            possibleChars.Add('p');
            possibleChars.Add('q');
            possibleChars.Add('r');
            possibleChars.Add('s');
            possibleChars.Add('t');
            possibleChars.Add('u');
            possibleChars.Add('v');
            possibleChars.Add('w');
            possibleChars.Add('x');
            possibleChars.Add('y');
            possibleChars.Add('z');
      
            // upper and lower case selected?
            if (includeUpperAndLowerCaseCheckBox.Checked == true)
            {
                possibleChars.Add('A');
                possibleChars.Add('B');
                possibleChars.Add('C');
                possibleChars.Add('D');
                possibleChars.Add('E');
                possibleChars.Add('F');
                possibleChars.Add('G');
                possibleChars.Add('H');
                possibleChars.Add('I');
                possibleChars.Add('J');
                possibleChars.Add('K');
                possibleChars.Add('L');
                possibleChars.Add('M');
                possibleChars.Add('N');
                possibleChars.Add('O');
                possibleChars.Add('P');
                possibleChars.Add('Q');
                possibleChars.Add('R');
                possibleChars.Add('S');
                possibleChars.Add('T');
                possibleChars.Add('U');
                possibleChars.Add('V');
                possibleChars.Add('W');
                possibleChars.Add('X');
                possibleChars.Add('Y');
                possibleChars.Add('Z');
            }

            // see if we need to add numbers to our list
            if (includeNumbersCheckBox.Checked == true)
            {
                possibleChars.Add('0');
                possibleChars.Add('1');
                possibleChars.Add('2');
                possibleChars.Add('3');
                possibleChars.Add('4');
                possibleChars.Add('5');
                possibleChars.Add('6');
                possibleChars.Add('7');
                possibleChars.Add('8');
                possibleChars.Add('9');

            }

            // see if we need to add special characters to our list
            if (includeSpecialCharactersCheckBox.Checked == true)
            {
                possibleChars.Add('!');
                possibleChars.Add('@');
                possibleChars.Add('#');
                possibleChars.Add('$');
                possibleChars.Add('%');
                possibleChars.Add('^');
                possibleChars.Add('&');
                possibleChars.Add('*');
                possibleChars.Add('(');
                possibleChars.Add(')');
                possibleChars.Add('~');
                possibleChars.Add('`');
                possibleChars.Add('-');
                possibleChars.Add('_');
                possibleChars.Add('[');
                possibleChars.Add(']');
                possibleChars.Add(';');
                possibleChars.Add('=');
                possibleChars.Add('+');
            }

            int maxCounter = 0;
            if (generateOnePassRadioButton.Checked == true)
            {
                maxCounter = 1;
            }
            if (generateFivePasswordsRadioButton.Checked == true)
            {
                maxCounter = 5;
            }

            // prep a random number generator and int r to be used to scan the list
            Random rnd = new Random();
            int r = 0;
            // for efficiency use int totalChars to reduce recursive calls on possibleChars.Count
            int totalChars = possibleChars.Count;

            String thisPass = "";
            for(int x = 0; x < maxCounter; x++)
            {
                thisPass = "";
                for(int y = 0; y < 15; y++)
                {
                    r = rnd.Next(totalChars);
                    thisPass = thisPass + possibleChars[r].ToString();
                }
                resultsListBox.Items.Add(thisPass);
            }

            //reset radio buttons for next use
            generateOnePassRadioButton.Checked = true;
            generateFivePasswordsRadioButton.Checked = false;

        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            copyButton.Enabled = true;
            Clipboard.SetText(resultsListBox.GetItemText(resultsListBox.SelectedItem));
        }

    }
}
