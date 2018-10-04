namespace PenkoCourseWork
{
    partial class GameMenu
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
            this.Start = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(432, 72);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(271, 127);
            this.Start.TabIndex = 0;
            this.Start.Text = "НАЧАТЬ";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Help
            // 
            this.Help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Help.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Help.Location = new System.Drawing.Point(432, 247);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(271, 134);
            this.Help.TabIndex = 1;
            this.Help.Text = "ПОМОЩЬ";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Exit.Location = new System.Drawing.Point(432, 426);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(271, 132);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "ВЫХОД";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PenkoCourseWork.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 622);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Start);
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Exit;
    }
}