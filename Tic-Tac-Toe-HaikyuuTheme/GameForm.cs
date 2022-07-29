using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_HaikyuuTheme
{
    public partial class GameForm : Form
    {
        bool flip = false;
        int count = 0;
        public GameForm()
        {
            InitializeComponent();
        }

        private void PlayerSet_Click(object sender, EventArgs e)
        {
            flip = !flip;
            if (flip)
            {
                PlayerSet.BackgroundImage = Properties.Resources.PlayerSet21;
            }

            else
            {
                PlayerSet.BackgroundImage = Properties.Resources.PlayerSet11;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The players will take turns putting their marks in the empty spaces. Whoever got 3 of their marks in a row, whether up, down, across, or diagonally, will be the winner.");

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoCreator_Click(object sender, EventArgs e)
        {

        }

        private void GameBlock_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
    }
}
