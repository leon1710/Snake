namespace Snake
{
    partial class Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.counter = new System.Windows.Forms.Label();
            this.counter1 = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.BackColor = System.Drawing.Color.Black;
            this.counter.ForeColor = System.Drawing.Color.Yellow;
            this.counter.Location = new System.Drawing.Point(272, 0);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(54, 17);
            this.counter.TabIndex = 1;
            this.counter.Text = "points: ";
            this.counter.Click += new System.EventHandler(this.counter_Click);
            // 
            // counter1
            // 
            this.counter1.AutoSize = true;
            this.counter1.BackColor = System.Drawing.Color.Black;
            this.counter1.ForeColor = System.Drawing.Color.Yellow;
            this.counter1.Location = new System.Drawing.Point(321, 0);
            this.counter1.Name = "counter1";
            this.counter1.Size = new System.Drawing.Size(16, 17);
            this.counter1.TabIndex = 2;
            this.counter1.Text = "0";
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.ForeColor = System.Drawing.Color.Lime;
            this.gameOver.Location = new System.Drawing.Point(132, 126);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(100, 68);
            this.gameOver.TabIndex = 3;
            this.gameOver.Text = "Game Over\r\n\r\nNew Game - N\r\nExit - Esc";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(354, 323);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.counter1);
            this.Controls.Add(this.counter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Snake_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label counter1;
        private System.Windows.Forms.Label gameOver;
    }
}

