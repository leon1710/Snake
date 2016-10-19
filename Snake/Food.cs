using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        private int x, y, width, height;
        //private int r, g, b;

        private SolidBrush brush;
        public Rectangle foodRec;

        //Constructor
        public Food(Random randFood)
        {
            this.x = randFood.Next(0, 26) * 10;
            this.y = randFood.Next(0, 26) * 10;
            this.brush = new SolidBrush(getRandCol());

            this.width = 10;
            this.height = 10;

            foodRec = new Rectangle(x, y, width, height);
        }

        public Color getRandCol()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(254), random.Next(254), random.Next(254));
        }

        public void foodColor(Random randFood)
        {
            this.brush = new SolidBrush(getRandCol());
        }

        public void foodLocation(Random randFood)
        {
            this.x = randFood.Next(0, 26) * 10;
            this.y = randFood.Next(0, 26) * 10;
        }

        public void drawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;

            paper.FillRectangle(brush, foodRec);
        }

    }
}
