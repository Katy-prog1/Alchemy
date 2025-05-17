namespace Alchemy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAlchemy = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnRecipes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlchemy
            // 
            this.lblAlchemy.AutoSize = true;
            this.lblAlchemy.BackColor = System.Drawing.Color.Transparent;
            this.lblAlchemy.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlchemy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAlchemy.Location = new System.Drawing.Point(233, 45);
            this.lblAlchemy.Name = "lblAlchemy";
            this.lblAlchemy.Size = new System.Drawing.Size(353, 105);
            this.lblAlchemy.TabIndex = 0;
            this.lblAlchemy.Text = "Alchemy";
            this.lblAlchemy.Click += new System.EventHandler(this.lblAlchemy_Click);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.FlatAppearance.BorderSize = 0;
            this.lblStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStart.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Transparent;
            this.lblStart.Location = new System.Drawing.Point(324, 153);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(167, 43);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            this.lblStart.UseVisualStyleBackColor = false;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.Transparent;
            this.btnScores.FlatAppearance.BorderSize = 0;
            this.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScores.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.ForeColor = System.Drawing.Color.Transparent;
            this.btnScores.Location = new System.Drawing.Point(266, 202);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(271, 40);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "View Scores";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnRecipes
            // 
            this.btnRecipes.BackColor = System.Drawing.Color.Transparent;
            this.btnRecipes.FlatAppearance.BorderSize = 0;
            this.btnRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipes.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipes.ForeColor = System.Drawing.Color.Transparent;
            this.btnRecipes.Location = new System.Drawing.Point(266, 265);
            this.btnRecipes.Name = "btnRecipes";
            this.btnRecipes.Size = new System.Drawing.Size(271, 48);
            this.btnRecipes.TabIndex = 3;
            this.btnRecipes.Text = "View Recipes";
            this.btnRecipes.UseVisualStyleBackColor = false;
            this.btnRecipes.Click += new System.EventHandler(this.btnRecipes_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(266, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(271, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alchemy.Properties.Resources._75fd52602689945ecb73040c1138de1f;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRecipes);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblAlchemy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlchemy;
        private System.Windows.Forms.Button lblStart;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnRecipes;
        private System.Windows.Forms.Button btnExit;
    }
}

