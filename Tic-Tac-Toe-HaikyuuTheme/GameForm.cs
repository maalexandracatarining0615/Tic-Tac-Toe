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

            //1st Row (Block A - Block C)
            Kageyamax1y1.Visible = false;
            Hinatax1y1.Visible = false;

            Kageyamax2y1.Visible = false;
            Hinatax2y1.Visible = false;

            Kageyamax3y1.Visible = false;
            Hinatax3y1.Visible = false;

            //2nd Row (Block D - Block F)
            Kageyamax1y2.Visible = false;
            Hinatax1y2.Visible = false;

            Kageyamax2y2.Visible = false;
            Hinatax2y2.Visible = false;

            Kageyamax3y2.Visible = false;
            Hinatax3y2.Visible = false;

            //3rd Row (Block G - Block I)
            Kageyamax1y3.Visible = false;
            Hinatax1y3.Visible = false;

            Kageyamax2y3.Visible = false;
            Hinatax2y3.Visible = false;

            Kageyamax3y3.Visible = false;
            Hinatax3y3.Visible = false;
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
            MessageBox.Show("The players will take turns putting their marks in the empty spaces. You can switch the players by clicking the button above. Whoever got 3 of their marks in a row, whether up, down, across, or diagonally, will be the winner.");

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

        private void Kageyamax1y1_Click(object sender, EventArgs e)
        {
            //Kageyamax1y1.Visible = false;

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonA.Visible = false;
            PlayerSet.Enabled = false;

            if (flip)
            {
                Kageyamax1y1.Visible = true;
            }

            else
            {
                Hinatax1y1.Visible = true;
            }
            
            
            //Winning Codes for Player Kageyama O
            if (Kageyamax1y1.Visible)
            {
                //OXX
                //OXX
                //OXX

                if (Kageyamax1y2.Visible)
                {
                    if (Kageyamax1y3.Visible)
                    {
                        MessageBox.Show("Player Kageyama O is the winner!");
                        Application.Restart();
                    }
                }

                //OXX
                //XOX
                //XXO

                if (Kageyamax2y2.Visible)
                {
                    if (Kageyamax3y3.Visible)
                    {
                        MessageBox.Show("Player Kageyama O is the winner!");
                        Application.Restart();
                    }
                }

                //OOO
                //XXX
                //XXX

                if (Kageyamax2y1.Visible)
                {
                    if (Kageyamax3y1.Visible)
                    {
                        //MessageBox.Show("Player Kageyama O is the winner!");
                    }

                }
            }

            if (Kageyamax2y1.Visible)
            {
                
                //XOX
                //XOX
                //XOX

                if (Kageyamax2y2.Visible)
                {
                    if (Kageyamax2y3.Visible)
                    {
                        MessageBox.Show("Player Kageyama O is the winner!");
                        Application.Restart();
                    }
                }
            }

            if (Kageyamax3y1.Visible)
            {

                //XXO
                //XXO
                //XXO
                if (Kageyamax3y2.Visible)
                {
                    if (Kageyamax3y3.Visible)
                    {
                        MessageBox.Show("Player Kageyama O is the winner!");
                        Application.Restart();
                    }
                }

                //XXO
                //XOX
                //OXX

                if (Kageyamax2y2.Visible)
                {
                    if (Kageyamax1y3.Visible)
                    {
                        MessageBox.Show("Player Kageyama O is the winner!");
                        Application.Restart();
                    }
                }

                //OOO
                //XXX
                //XXX

                if (Kageyamax2y1.Visible)
                {
                    if (Kageyamax1y1.Visible)
                    {
                        MessageBox.Show("Player Kageyama O is the winner!");
                        Application.Restart();
                    }
                }
            }

            if (Kageyamax1y2.Visible)
            {

                //XXX
                //OOO
                //XXX

                if (Kageyamax2y2.Visible)
                {
                    if (Kageyamax3y2.Visible)
                    {
                        MessageBox.Show("Player Kageyama O is the winner!");
                        Application.Restart();

                    }
                }
            }

            if (Kageyamax1y3.Visible)
            {

                //XXX
                //XXX
                //OOO

                if (Kageyamax2y3.Visible)
                {
                    if (Kageyamax3y3.Visible)
                    {
                        //MessageBox.Show("Player Kageyama O is the winner!);
                    }
                }
            }

            //Winning Codes for Player Hinata X

            if (Hinatax1y1.Visible)
            {

                //OXX
                //OXX
                //OXX

                if (Hinatax1y2.Visible)
                {
                    if (Hinatax1y3.Visible)
                    {
                        MessageBox.Show("Player Hinata X is the winner!");
                        Application.Restart();
                    }
                }

                //OXX
                //XOX
                //XXO

                if (Hinatax2y2.Visible)
                {
                    if (Hinatax3y3.Visible)
                    {
                        MessageBox.Show("Player Hinata X is the winner!");
                        Application.Restart();
                    }
                }
                //OOO
                //XXX
                //XXX

                if (Hinatax2y1.Visible)
                {
                    if (Hinatax3y1.Visible)
                    {
                        //MessageBox.Show("Player Hinata X is the winner!");
                    }
                }
            }

            if (Hinatax2y1.Visible)
            {

                //XOX
                //XOX
                //XOX

                if (Hinatax2y2.Visible)
                {
                    if (Hinatax2y3.Visible)
                    {
                        MessageBox.Show("Player Hinata X is the winner!");
                        Application.Restart();
                    }
                }
            }

            if (Hinatax3y1.Visible)
            {
                //XXO
                //XXO
                //XXO

                if (Hinatax3y2.Visible)
                {
                    if (Hinatax3y3.Visible)
                    {
                        MessageBox.Show("Player Hinata X is the winner!");
                        Application.Restart();
                    }
                }

                //XXO
                //XOX
                //OXX

                if (Hinatax2y2.Visible)
                {
                    if (Hinatax1y3.Visible)
                    {
                        MessageBox.Show("Player Hinata X is the winner!");
                        Application.Restart();
                    }
                }

                //OOO
                //XXX
                //XXX

                if (Hinatax2y1.Visible)
                {
                    if (Hinatax1y1.Visible)
                    {
                        MessageBox.Show("Player Hinata X is the winner!");
                        Application.Restart();
                    }
                }
            }

            if (Hinatax1y2.Visible)
            {

                //XXX
                //OOO
                //XXX
                if (Hinatax2y2.Visible)
                {
                    if (Hinatax3y2.Visible)
                    {
                        MessageBox.Show("Player Hinata X is the winner!");
                        Application.Restart();
                    }
                }
            }

            if (Hinatax1y3.Visible)
            {
                //XXX
                //XXX
                //OOO

                if (Hinatax2y3.Visible)
                {
                    if (Hinatax3y3.Visible)
                    {
                        //MessageBox.Show("Player Hinata X is the winner!");

                    }
                }
            }

            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("You are tie! You'll have to draw another game if you want a rematch!");
                Application.Restart();
            }

            flip = !flip;
        }

    }
}
