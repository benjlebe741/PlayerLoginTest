using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PlayerLoginTest
{
    public partial class Form1 : Form
    {
        string chosenDifficulty = "Not chosen";
        string username;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        //Animation Timer-------------------------------------
        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            if (chosenDifficulty == "WEAK") 
            { 
           easyButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(250);
                easyButton.BackColor = Color.LightGreen;
            }
            if (chosenDifficulty == "COWARDLY")
            {
              mediumButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(250);
                mediumButton.BackColor = Color.LightGoldenrodYellow;
            }
            if (chosenDifficulty == "BRAVE") 
            {
                hardButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(250);
                hardButton.BackColor = Color.Red;
            }
        }

        //Mouse hovering over buttons--------------------------------
        private void easyButton_MouseEnter(object sender, EventArgs e)
        {
            hardButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.Gray;
            easyButton.BackColor = Color.LightGreen;
        }

        private void mediumButton_MouseHover(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Gray;
            hardButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.LightGoldenrodYellow;
        }

        private void hardButton_MouseHover(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.Gray;
            hardButton.BackColor = Color.Red;
        }


        //When buttons are clicked--------------------------------
        private void easyButton_Click(object sender, EventArgs e)
        {
            chosenDifficulty = "WEAK";
            hardButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.Gray;
            loginButton.Visible = true;
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            chosenDifficulty = "COWARDLY";
            easyButton.BackColor = Color.Gray;
            hardButton.BackColor = Color.Gray;
            loginButton.Visible = true;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            chosenDifficulty = "BRAVE";
            easyButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.Gray;
            loginButton.Visible = true;
        }


        //Final Login Process!--------------------------------
        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text;

            //player has a path and name
            if (chosenDifficulty != "Not chosen" && username != "")
            {
                outputLabel.Text = $"Welcome {username}.... begin your journey down the path of the {chosenDifficulty}\nG o o d  L u c k";
                loginButton.Visible = false;

            }

            //player has path
            else if (username != "") { outputLabel.Text = $"{username}... It seems no journey has chosen you..."; }
            
            //player has name
            else if (chosenDifficulty != "Not chosen") { outputLabel.Text = $"{username}... Are you nameless?"; }
        }
    }
}
