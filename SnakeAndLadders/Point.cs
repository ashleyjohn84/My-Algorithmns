using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main1(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int cases = Convert.ToInt32(Console.ReadLine());
        var points = new List<Point>();
        for (int i = 0; i < cases; i++)
        {
            var input = Console.ReadLine().ToString();
            var inputs = input.Split(new char[] {' '}).Select(x => Convert.ToInt32(x)).ToList();
            Point px = new Point();
            px.x0 = inputs[0];
            px.x1 = inputs[1];
            px.y0 = inputs[2];
            px.y1 = inputs[3];
            points.Add(px);

        }
        Console.WriteLine();
        for (int i = 0; i < cases; i++)
        {
            Console.Write(points[i].x0);
            Console.Write(" ");
            Console.Write(points[i].x1);
            Console.WriteLine();
        }

    }

    class Point
    {
        public int x0, x1, y0, y1;
    }
}