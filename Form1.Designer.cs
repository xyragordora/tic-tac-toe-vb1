
namespace tictactoe2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.Transparent;
            this.play.Location = new System.Drawing.Point(304, 260);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(226, 103);
            this.play.TabIndex = 1;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about.BackgroundImage")));
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.Color.Transparent;
            this.about.Location = new System.Drawing.Point(308, 358);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(214, 83);
            this.about.TabIndex = 2;
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 506);
            this.Controls.Add(this.about);
            this.Controls.Add(this.play);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button about;
    }
}

