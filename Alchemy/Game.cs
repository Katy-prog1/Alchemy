using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Alchemy
{
    public partial class Game : Form
    {
        private string connectionString = "Server=Katy;Database=AlchemyDB;Integrated Security=True;";
        private int discoveredCount = 4;
        private Dictionary<string, PictureBox> elements = new Dictionary<string, PictureBox>();
        private Form1 mainWindow;

        public Game(Form1 mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            LoadInitialElements();
            UpdateDiscoveredCount();
        }

        private void LoadInitialElements()
        {
            AddElement("Air", GetImagePath("Air"));
            AddElement("Water", GetImagePath("Water"));
            AddElement("Earth", GetImagePath("Earth"));
            AddElement("Fire", GetImagePath("Fire"));
        }

        private void AddElement(string name, string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                MessageBox.Show($"Image not found: {imagePath}");
                return;
            }

            PictureBox picBox = new PictureBox
            {
                Image = Image.FromFile(imagePath),
                Size = new Size(64, 64),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = name,
                AllowDrop = true,
                Margin = new Padding(10)
            };
            picBox.MouseDown += Element_MouseDown;
            picBox.DragEnter += Element_DragEnter;
            picBox.DragDrop += Element_DragDrop;

            pnlElements.Controls.Add(picBox);
            elements[name] = picBox;
        }

        private void Element_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox != null)
            {
                picBox.DoDragDrop(picBox.Tag, DragDropEffects.Move);
            }
        }

        private void Element_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Element_DragDrop(object sender, DragEventArgs e)
        {
            string sourceElement = e.Data.GetData(typeof(string)) as string;
            PictureBox targetPicBox = sender as PictureBox;
            if (sourceElement != null && targetPicBox != null)
            {
                string targetElement = targetPicBox.Tag as string;
                string newElement = CombineElements(sourceElement, targetElement);
                if (!string.IsNullOrEmpty(newElement))
                {
                    AddNewElement(newElement);
                }
            }
        }

        private string CombineElements(string element1, string element2)
        {
            string result = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    int element1ID = GetElementID(conn, element1);
                    int element2ID = GetElementID(conn, element2);

                    string queryCombination = @"
                        SELECT er.ElementName AS ResultName 
                        FROM Combinations c
                        JOIN Elements er ON c.ResultElementID = er.ElementID
                        WHERE c.Element1ID = @element1ID AND c.Element2ID = @element2ID";

                    using (SqlCommand cmd = new SqlCommand(queryCombination, conn))
                    {
                        cmd.Parameters.AddWithValue("@element1ID", element1ID);
                        cmd.Parameters.AddWithValue("@element2ID", element2ID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            result = reader["ResultName"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return result;
        }

        private int GetElementID(SqlConnection conn, string elementName)
        {
            string queryElement = "SELECT ElementID FROM Elements WHERE ElementName = @elementName";
            using (SqlCommand cmd = new SqlCommand(queryElement, conn))
            {
                cmd.Parameters.AddWithValue("@elementName", elementName);
                return (int)cmd.ExecuteScalar();
            }
        }

        private string GetImagePath(string name)
        {
            string imagePath = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ImagePath FROM Elements WHERE ElementName = @name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            imagePath = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"No image path found for element: {name}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the image path: " + ex.Message);
            }
            return imagePath;
        }

        private void AddNewElement(string name)
        {
            if (!elements.ContainsKey(name))
            {
                string imagePath = GetImagePath(name);
                AddElement(name, imagePath);
                discoveredCount++;
                UpdateDiscoveredCount();
                SaveDiscoveredCount();
            }
        }

        private void UpdateDiscoveredCount()
        {
            lblCount.Text = $"{discoveredCount}";
        }

        private void SaveDiscoveredCount()
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            int count;
            if (!int.TryParse(lblCount.Text, out count))
            {
                MessageBox.Show("Invalid count value.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Scores WHERE PlayerName = @playerName";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@playerName", username);
                        int userCount = (int)cmdCheck.ExecuteScalar();

                        if (userCount > 0)
                        {
                            string updateQuery = "UPDATE Scores SET DiscoveredElementsCount = @count WHERE PlayerName = @playerName";
                            using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@playerName", username);
                                cmdUpdate.Parameters.AddWithValue("@count", count);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO Scores (PlayerName, DiscoveredElementsCount) VALUES (@playerName, @count)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@playerName", username);
                                cmdInsert.Parameters.AddWithValue("@count", count);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the score: " + ex.Message);
            }
        }




        private void Game_FormClosed(object sender, EventArgs e)
        {
            this.mainWindow.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void lblElementsOpen_Click(object sender, EventArgs e) { }

        private void lblCount_Click(object sender, EventArgs e) { }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void lblUserName_Click(object sender, EventArgs e) { }

        private void txtUsername_TextChanged(object sender, EventArgs e) { }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            SaveDiscoveredCount();
            MessageBox.Show("Score saved successfully!");
        }
    }
}

