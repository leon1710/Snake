using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Snake : Form
    {
        Random randFood = new Random();
        Graphics paper;
        Snake_Class snake = new Snake_Class();
        Food food;
        int count = 0;
        
        //directions
        bool left = false;
        bool right = false;
        bool down = false;
        bool up = false;

        public Snake()
        {
            InitializeComponent();
            food = new Food(randFood);
            gameOver.Visible = false;   // Game over window not visible
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            //wenn down gedrückt und snake richtung ist nicht up
            if(e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }
            //Pause game
            if(e.KeyData == Keys.P)
            {
                down = false;
                up = false;
                right = false;
                left = false;
            }
            // new game
            if(e.KeyData == Keys.N)
            {
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }
                randFood = new Random();
                snake = new Snake_Class();
                count = 0;
                //directions
                left = false;
                right = false;
                down = false;
                up = false;
                gameOver.Visible = false;
            }
            // Exit game
            if(e.KeyData == Keys.Escape)
            {
                this.Close();  
            }
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawFood(paper);
            snake.drawSnake(paper);  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (down)
            {
                snake.moveDown();
            }
            if (up)
            {
                snake.moveUp();
            }
            if (right)
            {
                snake.moveRight();
            }
            if (left)
            {
                snake.moveLeft();
            }

            // wenn snake array ein food Rec trifft
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    snake.growSnake();          // snake größer
                    food.foodLocation(randFood);// neue FoodLocation mit randFood
                    food.foodColor(randFood);
                    //food.getRandCol();
                    count++;                    // counter erhöhen
                    counter1.Text = count.ToString();  //counter anzeigen
                    /*
                    if(timer1.Interval > 0)
                    {
                        timer1.Interval -= 30;
                    }
                    */

                }
            }
            collision();
            this.Invalidate();

        }

        public void collision()
        {
            //collision mit sich selbst
            for(int i= 1; i< snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    timer1.Enabled = false;
                    gameOver.Visible = true;
                    //MessageBox.Show("snake is dead");
                }
            }

            //collision mit Rahmen 
            if(snake.SnakeRec[0].X <0 || snake.SnakeRec[0].X > 270)
            {
                timer1.Enabled = false;
                MessageBox.Show("snake is dead");
            }

            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 250)
            {
                timer1.Enabled = false;
                MessageBox.Show("snake is dead");
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            randFood = new Random();
            snake = new Snake_Class();
            count = 0;
            //directions
            left = false;
            right = false;
            down = false;
            up = false;
            gameOver.Visible = false;
        }

        private void counter_Click(object sender, EventArgs e)
        {

        }
    }
}
