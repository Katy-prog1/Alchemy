using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Alchemy
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=Katy;Database=AlchemyDB;Integrated Security=True;";


        public Form1()
        {
            InitializeComponent();
        }

        private void lblAlchemy_Click(object sender, EventArgs e)
        {
            
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Game gameForm = new Game(this);
            gameForm.Show();
            this.Hide();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            ViewScores scoresForm = new ViewScores(this);
            scoresForm.Show();
            this.Hide();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            ViewRecipes recipesForm = new ViewRecipes(this);
            recipesForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
