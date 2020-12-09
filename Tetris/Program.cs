﻿using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure s = new Stick(20, 5, '*');

            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();
            
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();

            //Figure[] f = new Figure[2];
            //f[0] = new Square(2, 5, '*');
            //f[1] = new Stick(6, 6, '*');

            //foreach (Figure fig in f)
            //{
            //    fig.Draw();
            //}

            //Square s = new Square(2, 5, '*');
            //s.Draw();


            //Stick stick = new Stick(6, 6, '*');
            //stick.Draw();

            //Point p1 = new Point(2, 3, '*');


            //Point p2 = new Point()
            //{
            //    x = 4,
            //    y = 5,
            //    c = '*'
            //};


            //p2.Draw();


            Console.ReadLine();
        }

    }
}
