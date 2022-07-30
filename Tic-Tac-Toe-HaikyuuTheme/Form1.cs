using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tic_Tac_Toe_HaikyuuTheme
{
    public partial class WelcomeForm : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public WelcomeForm()
        {
            InitializeComponent();

            player.SoundLocation = "haikyuubgmusic.wav";
        }

        private void WelcomePic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click a button below to start or quit the game.");
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            GameForm f2 = new GameForm();
            f2.Show();
            this.Hide();
        }

        private void No_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
            player.PlayLooping();
        }
    }
}