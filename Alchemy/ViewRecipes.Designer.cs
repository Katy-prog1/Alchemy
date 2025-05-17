namespace Alchemy
{
    partial class ViewRecipes
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
            this.components = new System.ComponentModel.Container();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.listViewRecipes = new System.Windows.Forms.ListView();
            this.imageListRecipes = new System.Windows.Forms.ImageList(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipes.Font = new System.Drawing.Font("MV Boli", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipes.ForeColor = System.Drawing.Color.White;
            this.lblRecipes.Location = new System.Drawing.Point(247, 44);
            this.lblRecipes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(125, 40);
            this.lblRecipes.TabIndex = 0;
            this.lblRecipes.Text = "Recipes";
            this.lblRecipes.Click += new System.EventHandler(this.lblRecipes_Click);
            // 
            // listViewRecipes
            // 
            this.listViewRecipes.HideSelection = false;
            this.listViewRecipes.Location = new System.Drawing.Point(43, 95);
            this.listViewRecipes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewRecipes.Name = "listViewRecipes";
            this.listViewRecipes.Size = new System.Drawing.Size(524, 118);
            this.listViewRecipes.TabIndex = 1;
            this.listViewRecipes.UseCompatibleStateImageBehavior = false;
            this.listViewRecipes.View = System.Windows.Forms.View.List;
            this.listViewRecipes.SelectedIndexChanged += new System.EventHandler(this.listViewRecipes_SelectedIndexChanged);
            // 
            // imageListRecipes
            // 
            this.imageListRecipes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListRecipes.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListRecipes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(215, 240);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(84, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(319, 226);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(271, 294);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alchemy.Properties.Resources._75fd52602689945ecb73040c1138de1f;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listViewRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewRecipes";
            this.Text = "ViewRecipes";
            this.Load += new System.EventHandler(this.ViewRecipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListView listViewRecipes;
        private System.Windows.Forms.ImageList imageListRecipes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
    }
}