using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGameWinForm
{
    class Food
    {
        public int x, y;
        public int size_a, size_b;
        

        public Food(int x, int y, int size_a, int size_b)
        {
            this.x = x;
            this.y = y;
            this.size_a = size_a;
            this.size_b = size_b;
        }

        public void CreateFood()
        {
            //var food = ;
            //Shapes.Remove(food);
            var food = Shapes.AddRectangle(size_a,size_b);
            Shapes.Move(food,x,y);
        }
    }
}
