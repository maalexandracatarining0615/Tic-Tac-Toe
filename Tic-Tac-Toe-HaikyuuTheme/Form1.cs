namespace Tic_Tac_Toe_HaikyuuTheme
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
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
    }
}