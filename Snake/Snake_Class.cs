using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake_Class
    {
        private Rectangle[] snakeRec;
        private SolidBrush brush;
        private int x, y, width, height;

        //Getter
        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
        }
        //Constructor
        public Snake_Class()
        {
            this.snakeRec = new Rectangle[3];
            this.brush = new SolidBrush(Color.Lime);

            this.x = 30;
            this.y = 50;
            this.width = 10;
            this.height = 10;

            for(int i=0; i<snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10; // position der anderen Segmente
            }
        }
        
        public void drawSnake(Graphics paper)
        {
            foreach(Rectangle rec in snakeRec)
            {
                paper.FillRectangle(brush, rec);
            }
        }//End drawSnake

        //movement of snake
        public void drawSnake()
        {
            for(int i = snakeRec.Length - 1; i>0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }

        public void moveDown()
        {
            drawSnake();
            snakeRec[0].Y += 10;
        }
        public void moveUp()
        {
            drawSnake();
            snakeRec[0].Y -= 10;
        }
        public void moveRight()
        {
            drawSnake();
            snakeRec[0].X += 10;
        }
        public void moveLeft()
        {
            drawSnake();
            snakeRec[0].X -= 10;
        }

        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            //take values of last and add a new rectangle to list
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X,snakeRec[snakeRec.Length - 1].Y,
                                  width,height));
            snakeRec = rec.ToArray();

        }
    }
}
