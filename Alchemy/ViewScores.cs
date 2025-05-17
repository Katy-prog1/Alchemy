using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alchemy
{
    public partial class ViewScores : Form
    {

        private string connectionString = "Server=Katy;Database=AlchemyDB;Integrated Security=True;";
        private Form1 mainWindow;

        public ViewScores(Form1 mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }


        private void ViewScores_Load(object sender, EventArgs e)
        {
            LoadScores();
        }

        private void LoadScores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ScoreID, PlayerName, DiscoveredElementsCount FROM Scores";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    listViewScores.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ScoreID"].ToString());
                        item.SubItems.Add(reader["PlayerName"].ToString());
                        item.SubItems.Add(reader["DiscoveredElementsCount"].ToString());

                        listViewScores.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ViewFormClosed(object sender, EventArgs e)
        {
            this.mainWindow.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }



        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void listViewScores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
