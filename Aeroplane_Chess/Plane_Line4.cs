﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Aeroplane_Chess
{
    class Plane_Line4
    {
        int[,] map4 =
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,9,9,9,9,9,9,9,2,0,0,0,0},
            {0,0,1,1,0,9,0,0,6,0,0,9,0,2,2,0,0},
            {0,0,1,1,0,9,0,0,6,0,0,9,0,2,2,0,0},
            {0,1,0,0,0,9,0,0,6,0,0,9,0,0,0,0,0},
            {0,9,9,9,9,0,0,0,6,0,0,0,9,9,9,9,0},
            {0,9,0,0,0,0,0,0,6,0,0,0,0,0,0,9,0},
            {0,9,0,0,0,0,0,0,6,0,0,0,0,0,0,9,0},
            {0,9,5,5,5,5,5,5,0,9,9,9,9,9,9,9,0},
            {0,9,0,0,0,0,0,0,7,0,0,0,0,0,0,0,0},
            {0,9,0,0,0,0,0,0,7,0,0,0,0,0,0,0,0},
            {0,9,9,9,9,0,0,0,7,0,0,0,9,9,9,9,0},
            {0,0,0,0,0,9,0,0,7,0,0,9,0,0,0,4,0},
            {0,0,3,3,0,9,0,0,7,0,0,9,0,4,4,0,0},
            {0,0,3,3,0,9,0,0,7,0,0,9,0,4,4,0,0},
            {0,0,0,0,3,9,9,9,9,9,9,9,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };
        public List<Point> plane_line4 = new List<Point>();
        public Plane_Line4()
        {
            int x = 12, y = 15;
            plane_line4.Add(new Point(12, 15));
            bool flag = true;
            while (flag)
            {
                flag = false;
                if (map4[x - 1, y] == 9)
                {
                    flag = true;
                    map4[x - 1, y] = 0;
                    plane_line4.Add(new Point(x - 1, y));
                }
                else if (map4[x, y - 1] == 9)
                {
                    flag = true;
                    map4[x, y - 1] = 0;
                    plane_line4.Add(new Point(x, y - 1));
                }
                else if (map4[x + 1, y] == 9)
                {
                    flag = true;
                    map4[x + 1, y] = 0;
                    plane_line4.Add(new Point(x + 1, y));
                }
                else if (map4[x, y + 1] == 9)
                {
                    flag = true;
                    map4[x, y + 1] = 0;
                    plane_line4.Add(new Point(x, y + 1));
                }
                else
                {
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (map4[i, j] == 9)
                            {
                                flag = true;
                                map4[i, j] = 0;
                                plane_line4.Add(new Point(i, j));
                            }
                        }
                    }
                }
                x = plane_line4[plane_line4.Count - 1].X;
                y = plane_line4[plane_line4.Count - 1].Y;
            }
        }
    }
}
