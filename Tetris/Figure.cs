using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGTH = 4;
        protected Point[] points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        internal void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            if(VerifyPosition(clone))
            {
                points = clone;
            }
            Draw();
        }

        private bool VerifyPosition(Point[] pList)
        {
            foreach(var p in pList)
            {
                if(p.x<0||p.y<0||p.x>=40||p.y>=30)
                {
                    return false;
                }
            }
            return true;
        }

        private void Move(Point[] clone, Direction dir)
        {
            foreach(var p in clone)
            {
                p.Move(dir);
            }
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];
            for (int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(points[i]);
            }
            return newPoints;
        }


        public abstract void Rotate();
        

        public void Hide()
        {
            foreach (Point p in points)
            {
                p.Hide();
            }
        }


    }
}
