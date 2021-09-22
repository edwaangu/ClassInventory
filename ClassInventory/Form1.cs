﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen, create object with gathered information
            if (nameInput.Text == "" || teamInput.Text == "" || positionInput.Text == "" || ageInput.Text == "")
            {
                outputLabel.Text = "Not all fields filled in...";
                return;
            }
            try
            {
                Player tempPlayer = new Player(nameInput.Text, teamInput.Text, positionInput.Text, Convert.ToInt32(ageInput.Text));

                // TODO - add object to global list
                players.Add(tempPlayer);

                // TODO - display message to indicate addition made
                outputLabel.Text = "New player added to database!";
            }
            catch
            {
                outputLabel.Text = "One or more inputs are invalid";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object is in list remove it

            // TODO - display message to indicate deletion made
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object entered exists in list show it
            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list. Use a foreach loop.
            outputLabel.Text = "";
            foreach (Player player in players)
            {
                outputLabel.Text += $"{player.name} - {player.age} - {player.team} - {player.position}\n";
            }
        }
    }
}
