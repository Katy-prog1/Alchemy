using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Alchemy
{
    public partial class ViewRecipes : Form
    {
        private string connectionString = "Server=Katy;Database=AlchemyDB;Integrated Security=True;";
        private Form1 mainWindow;

        public ViewRecipes(Form1 mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void ViewRecipes_Load(object sender, EventArgs e)
        {
            LoadRecipes();
        }

        private void LoadRecipes(string filter = "", string sort = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    e1.ElementName AS Element1Name, 
                    e1.ImagePath AS Element1Image,
                    e2.ElementName AS Element2Name, 
                    e2.ImagePath AS Element2Image,
                    er.ElementName AS ResultName,
                    er.ImagePath AS ResultImage
                FROM 
                    Combinations c
                JOIN 
                    Elements e1 ON c.Element1ID = e1.ElementID
                JOIN 
                    Elements e2 ON c.Element2ID = e2.ElementID
                JOIN 
                    Elements er ON c.ResultElementID = er.ElementID";

                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += " WHERE e1.ElementName LIKE @filter OR e2.ElementName LIKE @filter OR er.ElementName LIKE @filter";
                    }

                    if (!string.IsNullOrEmpty(sort))
                    {
                        query += $" ORDER BY {sort}";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(filter))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                    }
                    SqlDataReader reader = cmd.ExecuteReader();

                    listViewRecipes.Items.Clear();
                    imageListRecipes.Images.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = $"{reader["Element1Name"]} + {reader["Element2Name"]} = {reader["ResultName"]}";

                        Image element1Image = Image.FromFile(reader["Element1Image"].ToString());
                        Image element2Image = Image.FromFile(reader["Element2Image"].ToString());
                        Image resultImage = Image.FromFile(reader["ResultImage"].ToString());

                        imageListRecipes.Images.Add(element1Image);
                        imageListRecipes.Images.Add(element2Image);
                        imageListRecipes.Images.Add(resultImage);

                        item.ImageIndex = imageListRecipes.Images.Count - 3;

                        listViewRecipes.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void lblRecipes_Click(object sender, EventArgs e)
        {

        }

        private void listViewRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            LoadRecipes(filter);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }
    }
}
