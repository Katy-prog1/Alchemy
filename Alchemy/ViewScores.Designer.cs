namespace Alchemy
{
    partial class ViewScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewScores = new System.Windows.Forms.ListView();
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(141, 46);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(356, 50);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "User Scores Table";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(222, 285);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(184, 37);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listViewScores
            // 
            this.listViewScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnScore});
            this.listViewScores.HideSelection = false;
            this.listViewScores.Location = new System.Drawing.Point(140, 121);
            this.listViewScores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewScores.Name = "listViewScores";
            this.listViewScores.Size = new System.Drawing.Size(348, 149);
            this.listViewScores.TabIndex = 3;
            this.listViewScores.UseCompatibleStateImageBehavior = false;
            this.listViewScores.View = System.Windows.Forms.View.Details;
            this.listViewScores.SelectedIndexChanged += new System.EventHandler(this.listViewScores_SelectedIndexChanged);
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "User Name";
            this.columnUserName.Width = 196;
            // 
            // columnScore
            // 
            this.columnScore.Text = "Score";
            this.columnScore.Width = 252;
            // 
            // ViewScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alchemy.Properties.Resources._75fd52602689945ecb73040c1138de1f;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listViewScores);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewScores";
            this.Text = "ViewScores";
            this.Load += new System.EventHandler(this.ViewScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listViewScores;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnScore;
    }
}