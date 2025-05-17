using System;

namespace Alchemy
{
    partial class Game
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
            this.lblElementsOpen = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlElements = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElementsOpen
            // 
            this.lblElementsOpen.AutoSize = true;
            this.lblElementsOpen.BackColor = System.Drawing.Color.Transparent;
            this.lblElementsOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblElementsOpen.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementsOpen.ForeColor = System.Drawing.Color.Transparent;
            this.lblElementsOpen.Location = new System.Drawing.Point(52, 29);
            this.lblElementsOpen.Name = "lblElementsOpen";
            this.lblElementsOpen.Size = new System.Drawing.Size(254, 40);
            this.lblElementsOpen.TabIndex = 0;
            this.lblElementsOpen.Text = "Elements Open:";
            this.lblElementsOpen.Click += new System.EventHandler(this.lblElementsOpen_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCount.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(312, 29);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 45);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // pnlElements
            // 
            this.pnlElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlElements.BackColor = System.Drawing.Color.Transparent;
            this.pnlElements.CausesValidation = false;
            this.pnlElements.Location = new System.Drawing.Point(59, 74);
            this.pnlElements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlElements.Name = "pnlElements";
            this.pnlElements.Size = new System.Drawing.Size(680, 283);
            this.pnlElements.TabIndex = 2;
            this.pnlElements.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(344, 395);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(384, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 40);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User:";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(504, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveScore.FlatAppearance.BorderSize = 0;
            this.btnSaveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveScore.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScore.ForeColor = System.Drawing.Color.White;
            this.btnSaveScore.Location = new System.Drawing.Point(305, 361);
            this.btnSaveScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(248, 41);
            this.btnSaveScore.TabIndex = 6;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = false;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alchemy.Properties.Resources._75fd52602689945ecb73040c1138de1f;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlElements);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblElementsOpen);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label lblElementsOpen;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.FlowLayoutPanel pnlElements;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSaveScore;
    }
}