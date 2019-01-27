using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Microsoft.SmallBasic.Library;

namespace TurtleGameWinForm
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            Food apple = new Food(200,200,10,10);            

            apple.CreateFood();

            Random r = new Random();

            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= apple.x && Turtle.X <= apple.x + 10 && Turtle.Y >= apple.y && Turtle.Y <= apple.y + 10)
                {
                    apple.x = r.Next(0, GraphicsWindow.Width);
                    apple.y = r.Next(0, GraphicsWindow.Height);
                    apple.CreateFood();
                }
                
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if(GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if(GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if(GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
